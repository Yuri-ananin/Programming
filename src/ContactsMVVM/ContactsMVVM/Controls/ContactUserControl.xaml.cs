using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ContactsMVVM.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactUserControl.xaml
    /// </summary>
    public partial class ContactUserControl : UserControl
    {
        /// <summary>
        /// Свойство блокировки полей контакта. <see cref="DependencyProperty"/>.
        /// </summary>
        public static readonly DependencyProperty IsReadOnlyProperty = DependencyProperty.Register(
        "IsReadOnly",
        typeof(bool),
        typeof(ContactUserControl),
        new FrameworkPropertyMetadata(false));

        /// <summary>
        /// Возвращает и задаёт блокировку полей для ввода данных контакта.
        /// </summary>
        public bool IsReadOnly
        {
            get { return (bool)GetValue(IsReadOnlyProperty); }
            set { SetValue(IsReadOnlyProperty, value); }
        }

        /// <summary>
        /// Обработчик события PreviewTextInput для текстового поля контактного номера телефона.
        /// Проверяет каждый вводимый символ и разрешает только цифры, знаки "+" и "-", 
        /// а также символы "(", ")" и пробелы. Если введенный символ не удовлетворяет этим условиям,
        /// предотвращает дальнейший ввод этого символа в текстовое поле, устанавливая
        /// свойство Handled объекта TextCompositionEventArgs в true.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события PreviewTextInput.</param>
        private void ContactPhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0) && !"+-() ".Contains(e.Text))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Обработчик события Pasting для текстового поля контактного номера телефона.
        /// Проверяет текст, который вставляется в текстовое поле, и разрешает только цифры, знаки "+" и "-", 
        /// а также символы "(", ")" и пробелы. Если вставленный текст не соответствует этим условиям,
        /// отменяет команду вставки, предотвращая нежелательный текст в текстовом поле.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события DataObjectPastingEventArgs.</param>
        private void ContactPhoneNumberTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string pastedText = (string)e.DataObject.GetData(typeof(string));

                if (!System.Text.RegularExpressions.Regex.IsMatch(pastedText, @"^[\d+\-() ]+$"))
                {
                    e.CancelCommand();
                }
            }
        }

        /// <summary>
        /// Создание пользовательского элемента управления <see cref="UserControl"/>.
        /// </summary>
        public ContactUserControl()
        {
            InitializeComponent();
        }
    }
}