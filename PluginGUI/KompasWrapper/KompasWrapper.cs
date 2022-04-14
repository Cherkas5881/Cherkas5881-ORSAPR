using System;
using System.Runtime.InteropServices;
using Kompas6API5;
using Kompas6Constants3D;

namespace KompasWrapper
{
	/// <summary>
	/// Класс для работы с Компас 3D
	/// </summary>
	public class KompasWrapper
	{
		/// <summary>
		/// Возвращает экземпляр Компас 3D
		/// </summary>
		public KompasObject KompasObject { get; private set; }

		/// <summary>
		/// Запускает Компас 3D
		/// </summary>
		public void RunKompas()
		{
			if (KompasObject == null)
			{
				// Создаем экземпляр API Компаса
				var kompasType = Type.GetTypeFromProgID(
					"KOMPAS.Application.5");
				KompasObject = (KompasObject)Activator.CreateInstance(kompasType);
			}

			// Попытка открыть компас (Дается 3 попытки)
			if (KompasObject != null)
			{
				var retry = true;
				short tried = 0;
				while (retry)
				{
					try
					{
						tried++;
						KompasObject.Visible = true;
						retry = false;
					}
					catch (COMException)
					{
						var kompasType = Type.GetTypeFromProgID("KOMPAS.Application.5");
						KompasObject =
							(KompasObject)Activator.CreateInstance(kompasType);

						if (tried > 3)
						{
							retry = false;
						}
					}
				}

				KompasObject.ActivateControllerAPI();
			}
		}

		/// <summary>
		/// Выдавливание объекта
		/// </summary>
		/// <param name="part"></param>
		/// <param name="sketch"></param>
		/// <param name="height"></param>
		/// <param name="directionType"></param>
		public void BossExtrusion(ksPart part, ksEntity sketch, double height, Direction_Type directionType)
		{
			// Создаем объект выдавливания
			ksEntity extrude = part.NewEntity((int)Obj3dType.o3d_bossExtrusion);
			// Определяем объект выдавливания
			ksBossExtrusionDefinition extrudeDefinition = extrude.GetDefinition();
			// Устанавливаем тип выдавливания
			extrudeDefinition.directionType = (short)directionType;
			// Устанавливаем эскиз, который будет выдавливаться
			extrudeDefinition.SetSketch(sketch);
			// Получаем параметры выдавливания
			ksExtrusionParam extrudeParam = extrudeDefinition.ExtrusionParam();
			// Устанавливаем, на сколько нужно выдавить эскиз
			extrudeParam.depthNormal = height;
			// Выдавлием эскиз
			extrude.Create();
		}

		/// <summary>
		/// Создание плоскости относительно плоскости <see cref="type"/> на расстоянии <see cref="offsetValue"/> 
		/// </summary>
		/// <param name="part"></param>
		/// <param name="offsetValue"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		public ksEntity CreatePlaneOffset(ksPart part, double offsetValue, Obj3dType type)
		{
			// Получаем стандартную плоскость
			ksEntity plane = part.GetDefaultEntity((short)type);
			// Получаем новый объект относительной плоскости
			ksEntity planeOffset = part.NewEntity((int)Obj3dType.o3d_planeOffset);
			// Определяем относительную плоскость
			ksPlaneOffsetDefinition planeOffsetDefinition = planeOffset.GetDefinition();
			// Устанавливаем значения
			planeOffsetDefinition.direction = true;
			planeOffsetDefinition.offset = offsetValue;
			planeOffsetDefinition.SetPlane(plane);
			// Создаем относительную плоскость
			planeOffset.Create();
			// Возвращаем относительную плоскость
			return planeOffset;
		}
	}
}