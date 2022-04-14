namespace Core
{
	/// <summary>
	/// Класс параметров
	/// </summary>
	public class Parameters
	{
		/// <summary>
		/// Возвращает и задает глубину шкафа
		/// </summary>
		public int DepthBookcase { get; set; }

		/// <summary>
		/// Возвращает и задает высоту шкафа
		/// </summary>
		public int HeightBookcase { get; set; }

		/// <summary>
		/// Возвращает и задает высоты полки
		/// </summary>
		public int HeightShelf { get; set; }

		/// <summary>
		/// Возвращает и задает толщину материала
		/// </summary>
		public int MaterialThickness { get; set; }

		/// <summary>
		/// Возвращает и задает ширину шкафа
		/// </summary>
		public int WidthBookcase { get; set; }

		/// <summary>
		/// Возвращает и устанавливает тип ножек
		/// </summary>
		public LegType LegType { get; set; }

		/// <summary>
		///  Конструктор
		/// </summary>
		public Parameters()
		{
			WidthBookcase = 500;
			HeightBookcase = 2000;
			DepthBookcase = 200;
			MaterialThickness = 20;
			HeightShelf = 100;
			LegType = LegType.Circle;
		}
	}
}