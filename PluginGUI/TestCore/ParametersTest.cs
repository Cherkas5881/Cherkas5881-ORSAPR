using System;
using System.Collections.Generic;
using Core;
using NUnit.Framework;

namespace TestCore
{
	/// <summary>
	/// Класс для тестирования <see cref="Parameters"/>
	/// </summary>
	[TestFixture]
	public class ParametersTest
	{
		/// <summary>
		/// Массив названий параметров
		/// </summary>
		private static readonly string[] Names = 
			{ "WidthBookcase", "HeightBookcase", 
				"DepthBookcase", "HeightShelf",
				"MaterialThickness" };

		/// <summary>
		/// Возвращает новый экземпляр параметров
		/// </summary>
		private static Parameters Parameters => new Parameters();

		/// <summary>
		/// Словарть для проверки получения значения
		/// </summary>
		private readonly Dictionary<string, Func<int>> _parametersGetter =
			new Dictionary<string, Func<int>>()
		{
			{
				Names[0],
				() => Parameters.WidthBookcase
			},
			{
				Names[1],
				() => Parameters.HeightBookcase
			},
			{
				Names[2],
				() => Parameters.DepthBookcase
			},
			{
				Names[3],
				() => Parameters.HeightShelf
			},
			{
				Names[4],
				() => Parameters.MaterialThickness
			},
		};

		/// <summary>
		/// Словарть для проверки установления значения
		/// </summary>
		private readonly Dictionary<string, Action<Parameters, int>> _parametersSetter = 
			new Dictionary<string, Action<Parameters, int>>()
		{
			{
				Names[0],
				(parameters, value) => parameters.WidthBookcase = value
			},
			{
				Names[1],
				(parameters, value) => parameters.HeightBookcase = value
			},
			{
				Names[2],
				(parameters, value) => parameters.DepthBookcase = value
			},
			{
				Names[3],
				(parameters, value) => parameters.HeightShelf = value
			},
			{
				Names[4],
				(parameters, value) => parameters.MaterialThickness = value
			},
		};

		[TestCase ("WidthBookcase", 500, 
			TestName = "Проверка корректного получения" +
			           " значения свойства WidthBookcase.")]
		[TestCase ("HeightBookcase", 2000, 
			TestName = "Проверка корректного получения" +
					   " значения свойства HeightBookcase.")]
		[TestCase ("DepthBookcase", 200, 
			TestName = "Проверка корректного получения" +
					   " значения свойства DepthBookcase.")]
		[TestCase ("HeightShelf", 100, 
			TestName = "Проверка корректного получения" +
					   " значения свойства HeightShelf.")]
		[TestCase ("MaterialThickness", 20, 
			TestName = "Проверка корректного получения" +
					   " значения свойства MaterialThickness.")]
		public void TestGet(string key, int expected)
		{
			var actual = _parametersGetter[key].Invoke();
			Assert.AreEqual(expected, actual,
				"Вернулось некорректное значение!");
		}

		[TestCase("WidthBookcase", 600,
			TestName = "Проверка корректного установка" +
			           " значения свойства WidthBookcase.")]
		[TestCase("HeightBookcase", 3000,
			TestName = "Проверка корректного установка" +
			           " значения свойства HeightBookcase.")]
		[TestCase("DepthBookcase", 100,
			TestName = "Проверка корректного установка" +
			           " значения свойства DepthBookcase.")]
		[TestCase("HeightShelf", 200,
			TestName = "Проверка корректного установка" +
			           " значения свойства HeightShelf.")]
		[TestCase("MaterialThickness", 30,
			TestName = "Проверка корректного установка" +
			           " значения свойства MaterialThickness.")]
		public void TestSet(string key, int value)
		{
			var parameters = Parameters;

			Assert.DoesNotThrow(()=> _parametersSetter[key].Invoke(parameters, value),
				"Выкинулось исключение при попытке установления значения");
		}

		[TestCase(TestName = "Проверка корректного установка" +
							 " значения свойства LegType.")]
		public void TestSetLegType()
		{
			var parameters = Parameters;

			Assert.DoesNotThrow(() => parameters.LegType = LegType.Rectangle,
				"Выкинулось исключение при попытке установления значения");
		}

		[TestCase(TestName = "Проверка корректного получения" +
		                     " значения свойства LegType.")]
		public void TestGetLegType()
		{
			var parameters = Parameters;
			var expected = LegType.Circle;
			var actual = parameters.LegType;
			Assert.AreEqual(expected, actual,
				"Вернулось некорректное значение!");
		}
	}
}
