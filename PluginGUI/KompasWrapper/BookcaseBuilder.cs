using System;
using System.Collections.Generic;
using System.Windows;
using Core;
using Kompas6API5;
using Kompas6Constants3D;
using KompasAPI7;

namespace KompasWrapper
{
	/// <summary>
	/// Строитель шкафа
	/// </summary>
    public class BookcaseBuilder
	{
		/// <summary>
		/// Высота ножек
		/// </summary>
		private const int HeightTableLeg = 20;

		/// <summary>
		/// Ширина ножек
		/// </summary>
		private const int LegsWidth = 20;

		/// <summary>
		/// Первое расстояние от угла
		/// </summary>
		private const int LegsDistance1 = 28;

		/// <summary>
		/// Второе расстояние от угла
		/// </summary>
		private const int LegsDistance2 = 38;

		/// <summary>
		/// Экземпляр класса работы с Компас 3D
		/// </summary>
		private readonly KompasWrapper _kompasWrapper;

	    /// <summary>
	    /// Часть модели
	    /// </summary>
	    private ksPart _part;

	    /// <summary>
	    /// Параметры модели
	    /// </summary>
	    private Parameters _parameters;

	    /// <summary>
	    /// Координаты ножек комода
	    /// </summary>
	    private readonly List<Point> _legPoints = new List<Point>();

		/// <summary>
		/// Конструктор
		/// </summary>
		public BookcaseBuilder()
	    {
		    _kompasWrapper = new KompasWrapper();
	    }

	    /// <summary>
	    /// Построить модель
	    /// </summary>
	    /// <param name="parameters">Параметры</param>
	    public void Build(Parameters parameters)
	    {
			// Передаем значения параметров в класс
		    _parameters = parameters;
			// Запускаем компас
		    _kompasWrapper.RunKompas();
			// Создаем 3D документ, на котором будем строить шкаф
		    ksDocument3D document3D = _kompasWrapper.KompasObject.Document3D();
		    document3D.Create();
			// Получаем компонент сборки 
			_part = document3D.GetPart((int)Part_Type.pTop_Part);
			// Вызываем построение шкафа
			CreateBookcase();
			CreateLegs();
	    }

	    /// <summary>
	    /// Создать шкаф
	    /// </summary>
	    private void CreateBookcase()
	    {
			// Получаем стандартную плоскость XoZ
		    ksEntity plane = _part.GetDefaultEntity((int)Obj3dType.o3d_planeXOZ);
			// Получаем новый эскиз
		    ksEntity sketch = _part.NewEntity((int) Obj3dType.o3d_sketch);
			// Определяем эскиз
		    ksSketchDefinition sketchDefinition = sketch.GetDefinition();
			// Устанавливаем плоскость эскизу
		    sketchDefinition.SetPlane(plane);
		    // Создаем эскиз
			sketch.Create();

		    // Входим в режим редактирования эскиза
		    ksDocument2D document2D = sketchDefinition.BeginEdit();
			// Устанавливаем точки для главного прямоугольника
		    var firstPoint = new Point(0, 0);
		    var secondPoint = new Point(_parameters.WidthBookcase,
			    _parameters.HeightBookcase);
			// Создаем прямоугольник по двут точкам
		    CreateRectangle(firstPoint,
			    secondPoint, document2D);
			// Устанавливаме точки для первой плки
		    var x1 = _parameters.MaterialThickness;
		    var x2 = _parameters.WidthBookcase
		             - _parameters.MaterialThickness;
		    var y1 = _parameters.MaterialThickness;
		    var y2 = y1 + _parameters.HeightShelf;
		    var isContinue = true;
		    do
			{
				// Создаем прямоугольник по двут точкам
				CreateRectangle(new Point(x1, y1),
				    new Point(x2, y2), document2D);
				// Меняем координаты для следующей полки
			    y1 = y2 + _parameters.MaterialThickness;
			    y2 = y1 + _parameters.HeightShelf;
				// Проверка, можно ли еще добавить полку
			    if (y2 > _parameters.HeightBookcase)
			    {
					// Останавливаем построение полок
				    isContinue = false;
			    }
		    } while (isContinue);

		    // Выходим в режим редактирования эскиза
		    sketchDefinition.EndEdit();
		    // Выдавливаем эскиз
		    _kompasWrapper.BossExtrusion(_part, sketch, 
			    _parameters.DepthBookcase, Direction_Type.dtNormal);
	    }

	    /// <summary>
	    /// Создать ножки
	    /// </summary>
	    private void CreateLegs()
		{
			_legPoints.Clear();
			// Установка координат для ножек
			_legPoints.Add(new Point(LegsDistance1,
			    LegsDistance2));
		    _legPoints.Add(new Point(_parameters.WidthBookcase
		                             - LegsDistance1 - LegsWidth,
			    LegsDistance2));
		    _legPoints.Add(new Point(LegsDistance1,
			    _parameters.DepthBookcase - LegsDistance2 - LegsWidth));
		    _legPoints.Add(new Point(_parameters.WidthBookcase
		                             - LegsDistance1 - LegsWidth,
				_parameters.DepthBookcase - LegsDistance2 - LegsWidth));
			// Создаем плоскость параллельную XOY на расстоянии высоты шкафа
			ksEntity plane = _kompasWrapper.CreatePlaneOffset(
			    _part, -_parameters.HeightBookcase, Obj3dType.o3d_planeXOY);
			// Получаем новый эскиз
			ksEntity sketch = _part.NewEntity((int)Obj3dType.o3d_sketch);
			// Определяем эскиз
		    ksSketchDefinition sketchDefinition = sketch.GetDefinition();
		    // Устанавливаем эскизу плоскость 
		    sketchDefinition.SetPlane(plane);
			// Создаем эскиз
		    sketch.Create();

		    // Входим в режим редактирования эскиза
		    ksDocument2D document2D = sketchDefinition.BeginEdit();

			// Проходимся по координатам каждой ножки
		    foreach (var point1 in _legPoints)
		    {
			    switch (_parameters.LegType)
			    {
					// Строим круглую ножку
				    case LegType.Circle:
				    {
					    CreateEllipse(point1.X, point1.Y,
						    LegsWidth, LegsWidth,
						    document2D);
					    break;
				    }
					// Строим прямоугольную ножку
				    case LegType.Rectangle:
				    {
						CreateRectangle(new Point(point1.X, point1.Y),
							new Point(point1.X + LegsWidth, point1.Y + LegsWidth),
							document2D);
					    break;
				    }
					default:
					{
						throw new ArgumentOutOfRangeException();
					}
			    }
		    }

		    // Выходим в режим редактирования эскиза
			sketchDefinition.EndEdit();
			// Выдавливаем эскиз
			_kompasWrapper.BossExtrusion(_part, sketch, -HeightTableLeg,
			    Direction_Type.dtNormal);
	    }

		/// <summary>
		/// Создать прямоугольник по двум точкам
		/// </summary>
		/// <param name="point1"></param>
		/// <param name="point2"></param>
		private void CreateRectangle(Point point1,
		    Point point2, ksDocument2D document2D)
	    {
			// Находим растояние от X1 до X2
		    var length = Math.Abs(point1.X - point2.X);
		    // Находим растояние от Y1 до Y2
			var width = Math.Abs(point1.Y - point2.Y);
			// Строим 4 линии, которые замыкаются в прямоугольник
		    document2D.ksLineSeg(point1.X, point1.Y,
			    point1.X + length, point1.Y, 1);
		    document2D.ksLineSeg(point1.X + length, point1.Y,
			    point1.X + length, point1.Y + width, 1);
		    document2D.ksLineSeg(point1.X, point1.Y + width,
			    point1.X + length, point1.Y + width, 1);
		    document2D.ksLineSeg(point1.X, point1.Y,
			    point1.X, point1.Y + width, 1);
	    }

		/// <summary>
		/// Создает эллипс
		/// </summary>
		/// <param name="xc">Х координата центра эллипса</param>
		/// <param name="yc">Y координата центра эллипса</param>
		/// <param name="radius1">Первый радиус эллипса</param>
		/// <param name="radius2">Второй радиус эллипса</param>
		/// <param name="document2D">Эскиз</param>
		private void CreateEllipse(double xc, double yc,
			double radius1, double radius2, ksDocument2D document2D)
		{
			// Устанавливаем ID эллипса
			const int ellipseParamId = 22;
			// Получаем объект эллипса
			ksEllipseParam ellipseParam = _kompasWrapper.KompasObject.GetParamStruct(ellipseParamId);
			// Устанавливаем параметры
			ellipseParam.xc = xc;
			ellipseParam.yc = yc;
			ellipseParam.A = radius1;
			ellipseParam.B = radius2;
			ellipseParam.style = 1;
			// Отображаем на эскизе
			document2D.ksEllipse(ellipseParam);
		}
	}
}
