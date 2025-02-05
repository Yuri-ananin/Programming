using View.Model;
using System.ComponentModel;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс, описывающий VM для главного окна.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие, для отслеживаня изменений в свойствах.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Экземпляр класса <see cref="Contact"/>.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Возвращает и задаёт значение имя контакта. Вызывает событие.
        /// </summary>
        public string? Name
        {
            get => _contact.Name;
            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение номера телефона контакта. Вызывает событие.
        /// </summary>
        public string? Phone
        {
            get => _contact.Phone;
            set
            {
                _contact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение почты контакта. Вызывает событие.
        /// </summary>
        public string? Email
        {
            get => _contact.Email;
            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Метод для уведомления об изменении свойства объекта
        /// </summary>
        /// <param name="propertyName">Имя измененного свойства</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Возвращает и задаёт команду для сохранения контакта<see cref="Contact"/>.
        /// </summary>
        public ICommand SaveCommand { get; set; }

        /// <summary>
        /// Возвращает и задаёт команду для загрузки контакта<see cref="Contact"/>.
        /// </summary>
        public ICommand LoadCommand { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            SaveCommand = new JsonCommands((param) => ContactSerializer.SaveContact(_contact));
            LoadCommand = new JsonCommands((param) =>
            {
                _contact = ContactSerializer.LoadContact();
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Phone));
                OnPropertyChanged(nameof(Email));
            });
        }
    }
}