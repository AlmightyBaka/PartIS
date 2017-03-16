using System;
using FileHelpers;

namespace PartIS
{
	[DelimitedRecord(",")]
	[IgnoreFirst(1)]
	class Part
	{
		[FieldOrder(1), FieldTitle("№")]
		public int Count;
		[FieldOrder(2), FieldTitle("Фамилия")]
		public string Name;
		[FieldOrder(3), FieldTitle("Телефон")]
		public string Phone;
		[FieldOrder(4), FieldTitle("Название")]
		public string PartName;
		[FieldOrder(5), FieldTitle("Количество")]
		public int? Amount;
		[FieldOrder(6), FieldTitle("Пришла")]
		public DateTime? Received;
		[FieldOrder(7), FieldTitle("Выдали")]
		public DateTime? Sent;
	}
}
