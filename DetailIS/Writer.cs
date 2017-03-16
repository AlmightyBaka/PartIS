using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using FileHelpers;

namespace PartIS
{
	class Writer
	{
		private FileHelperEngine<Part> engine = new FileHelperEngine<Part>()
		{
			HeaderText = "№,Фамилия,Телефон,Название,Количество,Пришла,Выдали"
		};

		private string filePath;

		public Writer(string filePath)
		{
			engine.Encoding = Encoding.UTF8;
			this.filePath = filePath;
			if (!File.Exists(filePath))
			{
				engine.WriteFile(this.filePath, new Part[] { });
			}
		}

		public void Append(Part part)
		{
			engine.AppendToFile(filePath, part);
		}

		public List<Part> Read()
		{
			return engine.ReadFileAsList(filePath);
		}
	}
}

#region FileHelpers extension
// ReSharper disable CheckNamespace
namespace FileHelpers
// ReSharper restore CheckNamespace
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class FieldTitleAttribute : Attribute
	{
		public FieldTitleAttribute(string name)
		{
			if (name == null) throw new ArgumentNullException("name");
			Name = name;
		}

		public string Name { get; private set; }
	}

	public static class FileHelpersTypeExtensions
	{
		public static IEnumerable<string> GetFieldTitles(this Type type)
		{
			var fields = from field in type.GetFields(
				BindingFlags.GetField |
				BindingFlags.Public |
				BindingFlags.NonPublic |
				BindingFlags.Instance)
						 where field.IsFileHelpersField()
						 select field;

			return from field in fields
				   let attrs = field.GetCustomAttributes(true)
				   let order = attrs.OfType<FieldOrderAttribute>().Single().GetOrder()
				   let title = attrs.OfType<FieldTitleAttribute>().Single().Name
				   orderby order
				   select title;
		}

		public static string GetCsvHeader(this Type type)
		{
			return String.Join(",", type.GetFieldTitles());
		}

		static bool IsFileHelpersField(this FieldInfo field)
		{
			return field.GetCustomAttributes(true)
				.OfType<FieldOrderAttribute>()
				.Any();
		}

		static int GetOrder(this FieldOrderAttribute attribute)
		{
			// Hack cos FieldOrderAttribute.Order is internal (why?)
			var pi = typeof(FieldOrderAttribute)
				.GetProperty("Order",
					BindingFlags.GetProperty |
					BindingFlags.Instance |
					BindingFlags.NonPublic);

			return attribute.Order;
		}
	}
}
#endregion