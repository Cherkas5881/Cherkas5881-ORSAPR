using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core;
using KompasWrapper;

namespace PluginUI
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Параметры книжного шкафа
		/// </summary>
		private readonly Parameters _parameters = new Parameters();

		/// <summary>
		/// Строитель шкафа
		/// </summary>
		private readonly BookcaseBuilder _bookcaseBuilder = new BookcaseBuilder();

		/// <summary>
		/// Словарь действий. Ключ — поле для ввода значения <see cref="NumericUpDown"/>,
		/// Значение — действие изменения параметра.
		/// </summary>
		private readonly Dictionary<NumericUpDown, Action<int>> _actionParameters;

		/// <summary>
		/// Словарь типов ножек
		/// </summary>
		private readonly Dictionary<string, LegType> _legTypes = new Dictionary<string, LegType>
		{
			{"Круглые", LegType.Circle},
			{"Прямоугольные", LegType.Rectangle},
		};

		/// <summary>
		/// Конструктор
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			_actionParameters = new Dictionary<NumericUpDown, Action<int>>()
			{
				{
					WidthBookcaseNumericUpDown,
					// Устанавливаем значение свойству WidthBookcase
					value => _parameters.WidthBookcase = value
				},
				{
					HeightBookcaseNumericUpDown,
					value =>
					{
						// Устанавливаем значение свойству HeightBookcase
						_parameters.HeightBookcase = value;
						// Узменеям ограничения ширины шкафа
						WidthBookcaseNumericUpDown.Maximum = (int) (1.5 * value);
						// Изменеям текст справа от поля ввода ширины шкафа
						SetText(WidthBookcaseLabel, WidthBookcaseNumericUpDown);
						// Узменеям ограничения высоты полки
						HeightShelfNumericUpDown.Maximum = (int) (0.2 * value);
						// Изменеям текст справа от поля ввода высоты полки
						SetText(HeightShelfLabel, HeightShelfNumericUpDown);

					}
				},
				{
					DepthBookcaseNumericUpDown,
					// Устанавливаем значение свойству DepthBookcase
					value => _parameters.DepthBookcase = value
				},
				{
					HeightShelfNumericUpDown,
					value =>
					{
						// Устанавливаем значение свойству HeightShelf
						_parameters.HeightShelf = value;
						// Узменеям ограничения высоты шкафа
						HeightBookcaseNumericUpDown.Minimum = 5 * value;
						// Изменеям текст справа от поля вводавысоты шкафа
						SetText(HeightBookcaseLabel, HeightBookcaseNumericUpDown);
					}
				},
				{
					MaterialThicknessNumericUpDown,
					// Устанавливаем значение свойству MaterialThickness
					value => _parameters.MaterialThickness = value
				},
			};
			LegTypeCombobox.Items.AddRange(_legTypes.Keys.ToArray());
			LegTypeCombobox.SelectedIndex = 0;
		}

		/// <summary>
		/// Обработчик события наждатия на кнопку
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show(
				"Вы уверены что хотите построить модель с данными значениями?",
				"Внимание!", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				// Вызываем метод построения и посылаем парамтры,
				// которые ввел пользователь
				_bookcaseBuilder.Build(_parameters);
			}
		}

		/// <summary>
		/// Установить текст <see cref="Label"/>
		/// </summary>
		/// <param name="label"></param>
		/// <param name="numericUpDown"></param>
		private void SetText(Label label, NumericUpDown numericUpDown)
		{
			// Изменеям текст справа от поля ввода
			label.Text = $"от {numericUpDown.Minimum} до {numericUpDown.Maximum} мм";
		}

		/// <summary>
		/// Оброботчик события изменения значения в <see cref="NumericUpDown"/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			// Проверяем, что этот метод вызвал экземпляр класса NumericUpDown
			if (!(sender is NumericUpDown numericUpDown))
			{
				// Метод вызвал не экземпляр класса NumericUpDown
				return;
			}

			// Получаем значение из поля, которое было изменино
			var value = (int)numericUpDown.Value;
			// Изменяем значение в классе параметров
			_actionParameters[numericUpDown].Invoke(value);
		}

		/// <summary>
		/// Обработчик события измененрия выбора в комбобоксе
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LegTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			_parameters.LegType = _legTypes[LegTypeCombobox.Text];
		}
	}
}
