using ContactsMVVM.Model.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ContactsMVVM.ViewModel
{
    /// <summary>
    /// Работа с контактами.
    /// </summary>
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие для отслеживаня изменений в свойствах.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private ContactVM _selectedContact;

        /// <summary>
        /// Контакт, хранящий данные дло изменения. 
        /// </summary>
        private ContactVM _beforeEditingContact;

        /// <summary>
        /// Включение режима чтения.
        /// </summary>
        private bool _isReadOnly = true;

        /// <summary>
        /// Видимость кнопки Apply.
        /// </summary>
        private bool _isApplyButtonVisibility = false;

        /// <summary>
        /// Статус добавления данных.
        /// </summary>
        private bool _isAdding = false;

        /// <summary>
        /// Статус редактирования данных.
        /// </summary>
        private bool _isEditing = false;

        /// <summary>
        /// Возвращает и задаёт контакт.
        /// </summary>
        public ContactVM SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                if (_selectedContact != value)
                {
                    _selectedContact = value;

                    if (Contacts.Contains(value))
                    {
                        IsAdding = false;
                        if (IsEditing)
                        {
                            IsEditing = false;
                        }
                    }
                }
                OnPropertyChanged(nameof(SelectedContact));
            }
        }

        /// <summary>
        /// Возвращает и задаёт данные.
        /// </summary>
        public ContactVM BeforeEditingContact { get; set; }

        /// <summary>
        /// Возвращает и задаёт список контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задаёт команду для добавления контакта <see cref="ContactVM"/>.
        /// </summary>
        public RelayCommand AddCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду для удаления контакта <see cref="ContactVM"/>.
        /// </summary>
        public RelayCommand RemoveCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду для редактирования контакта <see cref="ContactVM"/>.
        /// </summary>
        public RelayCommand EditCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду для удаления контакта <see cref="ContactVM"/>.
        /// </summary>
        public RelayCommand ApplyCommand { get; private set; }

        /// <summary>
        /// Возвращает и задает свойство значения только для чтения.
        /// </summary>
        public bool IsReadOnly
        {
            get => _isReadOnly;
            set
            {
                if (_isReadOnly != value)
                {
                    if (value)
                    {
                        SelectedContact.PropertyChanged -= SelectedContact_PropertyChanged;
                    }
                    else
                    {
                        SelectedContact.PropertyChanged += SelectedContact_PropertyChanged;
                    }
                    ApplyButtonVisibility = !value;
                    _isReadOnly = value;
                    OnPropertyChanged(nameof(IsReadOnly));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт видимость кнопки Apply.
        /// </summary>
        public bool ApplyButtonVisibility
        {
            get => _isApplyButtonVisibility;
            set
            {
                if (_isApplyButtonVisibility != value)
                {
                    _isApplyButtonVisibility = value;
                    OnPropertyChanged(nameof(ApplyButtonVisibility));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт статус добавления контакта <see cref="ContactVM"/>.
        /// </summary>
        public bool IsAdding
        {
            get => _isAdding;
            set
            {
                if (_isAdding != value)
                {
                    IsReadOnly = !value;
                    _isAdding = value;
                    OnPropertyChanged(nameof(IsAdding));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт статус редактирования контакта <see cref="ContactVM"/>.
        /// </summary>
        public bool IsEditing
        {
            get => _isEditing;
            set
            {
                if (_isEditing != value)
                {
                    IsReadOnly = !value;
                    _isEditing = value;
                    OnPropertyChanged(nameof(IsEditing));
                }
            }
        }

        /// <summary>
        /// Метод для сохранения контактов.
        /// </summary>
        private void SaveContacts()
        {
            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Применение изменений у контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void ApplyChanges(object parameter)
        {
            SelectedContact.PropertyChanged -= SelectedContact_PropertyChanged;
            if (IsAdding)
            {
                Contacts.Add(SelectedContact);
                IsAdding = false;
            }

            if (IsEditing)
            {
                int index = Contacts.IndexOf(BeforeEditingContact);
                Contacts[index] = SelectedContact;
                OnPropertyChanged(nameof(BeforeEditingContact));
                SelectedContact = Contacts[index];
                IsEditing = false;
            }
            SaveContacts();
        }

        /// <summary>
        /// Добавление контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void AddContact(object parameter)
        {
            SelectedContact = null;
            SelectedContact = new ContactVM();
            IsAdding = true;
            OnPropertyChanged(nameof(IsAdding));
        }

        /// <summary>
        /// Редактирование контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void EditContact(object parameter)
        {
            BeforeEditingContact = SelectedContact;
            SelectedContact = (ContactVM)SelectedContact.Clone();
            IsEditing = true;
            OnPropertyChanged(nameof(EditContact));
        }

        /// <summary>
        /// Удаление контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void RemoveContact(object parameter)
        {
            int index = Contacts.IndexOf(SelectedContact);
            Contacts.Remove(SelectedContact);
            if (index < Contacts.Count - 1)
            {
                SelectedContact = Contacts[index];
            }
            else if (Contacts.Count > 1)
            {
                SelectedContact = Contacts[Contacts.Count - 1];
            }
            else
            {
                if (Contacts.Count == 1)
                    SelectedContact = Contacts[0];
                else
                    SelectedContact = null;
            }
            SaveContacts();
        }

        /// <summary>
        /// Загрузка контактов <see cref="ObservableCollection{ContactVM}"/>.
        /// </summary>
        private void LoadContacts()
        {
            Contacts = ContactSerializer.LoadContacts();
        }

        /// <summary>
        /// Проверка возможности применения изменений контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>True - доступно добавление контакта. False - недоступно.</returns>
        private bool CanApplyChanges(object parameter)
        {
            if (SelectedContact != null)
            {
                return !string.IsNullOrEmpty(SelectedContact.Name)
                        && !string.IsNullOrEmpty(SelectedContact.PhoneNumber)
                        && !string.IsNullOrEmpty(SelectedContact.Email);
            }
            return false;
        }

        /// <summary>
        /// Проверка возможности добавления контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>True - доступно добавление контакта. False - недоступно.</returns>
        private bool CanAddContact(object parameter) => !IsAdding;

        /// <summary>
        /// Проверка возможности редактирования контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter"Параметр.</param>
        /// <returns>True - доступно добавление контакта. False - недоступно.</returns>
        private bool CanEditContact(object parameter) => SelectedContact != null && !IsAdding && !IsEditing;

        /// <summary>
        /// Проверка возможности удаления контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>True - доступно удаление контакта. False - недоступно.</returns>
        private bool CanRemoveContact(object parameter) => SelectedContact != null && Contacts.Contains(SelectedContact);

        /// <summary>
        /// Отслеживание вохможности нажатия кнопки Apply.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedContact_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            ApplyCommand.RaiseCanExecuteChanged();
        }

        /// <summary>
        /// Обновляет состояние команд.
        /// </summary>
        private void UpdateCommands()
        {
            ApplyCommand.RaiseCanExecuteChanged();
            AddCommand.RaiseCanExecuteChanged();
            RemoveCommand.RaiseCanExecuteChanged();
            EditCommand.RaiseCanExecuteChanged();
        }

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="property">Название изменённого свойства.</param>
        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            UpdateCommands();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/> и задаёт команды для работы с ним <see cref="RelayCommand"/>.
        /// </summary>
        public MainVM()
        {
            ApplyCommand = new RelayCommand(ApplyChanges, CanApplyChanges);
            AddCommand = new RelayCommand(AddContact, CanAddContact);
            RemoveCommand = new RelayCommand(RemoveContact, CanRemoveContact);
            EditCommand = new RelayCommand(EditContact, CanEditContact);
            LoadContacts();

            if (Contacts != null && Contacts.Count > 0)
            {
                SelectedContact = Contacts[0];
            }
        }
    }
}