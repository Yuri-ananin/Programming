using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contacts.ViewModel.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Contacts.ViewModel
{
    /// <summary>
    /// ViewModel для работы с контактами <see cref="ObservableCollection{ContactVM}"/>.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Событие, для отслеживаня изменений в свойствах.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Текущий контакт.
        /// </summary>
        [ObservableProperty]
        private ContactVM _selectedContact;

        /// <summary>
        /// Контакт хранящий неизменённые данные. 
        /// </summary>
        [ObservableProperty]
        private ContactVM _beforeEditingContact;

        /// <summary>
        /// Включение режима чтения.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Видимость кнопки Apply.
        /// </summary>
        [ObservableProperty]
        private bool _isApplyButtonVisibility = false;

        /// <summary>
        /// Статус добавления данных.
        /// </summary>
        [ObservableProperty]
        private bool _isAdding = false;

        /// <summary>
        /// Статус редактирования данных.
        /// </summary>
        [ObservableProperty]
        private bool _isEditing = false;

        /// <summary>
        /// Действия при изменении контакта.
        /// </summary>
        /// <param name="oldValue">Предыдущее значение.</param>
        /// <param name="newValue">Новое значение.</param>
        partial void OnSelectedContactChanged(ContactVM oldValue, ContactVM newValue)
        {
            if (newValue != null)
            {
                newValue.PropertyChanged += SelectedContact_PropertyChanged;
            }
            if (oldValue != null)
            {
                oldValue.PropertyChanged -= SelectedContact_PropertyChanged;
            }

            if (Contacts.Contains(oldValue))
            {
                IsAdding = false;
                if (IsEditing)
                {
                    IsEditing = false;
                }
            }
            CanExecuteCommands();
        }

        /// <summary>
        /// Действия при изменении свойства ReadOnly у полей.
        /// </summary>
        /// <param name="oldValue">Предыдущее значение.</param>
        /// <param name="newValue">Новое значение.</param>
        partial void OnIsReadOnlyChanged(bool oldValue, bool newValue)
        {
            IsApplyButtonVisibility = !newValue;
            IsReadOnly = newValue;
        }

        /// <summary>
        /// Действия при изменении свойства добавления полей.
        /// </summary>
        /// <param name="oldValue">Предыдущее значение.</param>
        /// <param name="newValue">Новое значение.</param>
        partial void OnIsAddingChanged(bool oldValue, bool newValue)
        {
            IsReadOnly = !newValue;
        }

        /// <summary>
        /// Действия при изменении свойства редактирования полей.
        /// </summary>
        /// <param name="oldValue">Предыдущее значение.</param>
        /// <param name="newValue">Новое значение.</param>
        partial void OnIsEditingChanged(bool oldValue, bool newValue)
        {
            IsReadOnly = !newValue;
        }

        /// <summary>
        /// Возвращает и задаёт список контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Метод для сохранения контактов.
        /// </summary>
        private void SaveContacts()
        {
            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Загрузка контактов <see cref="ObservableCollection{ContactVM}"/>.
        /// </summary>
        private void LoadContacts()
        {
            Contacts = ContactSerializer.LoadContacts();
        }

        /// <summary>
        /// Применение изменений у контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        [RelayCommand(CanExecute = nameof(CanApplyChanges))]
        private void ApplyChanges(object parameter)
        {
            if (IsAdding)
            {
                Contacts.Add(SelectedContact);
                IsAdding = false;
            }

            if (IsEditing)
            {
                int index = Contacts.IndexOf(BeforeEditingContact);
                Contacts[index] = SelectedContact;
                SelectedContact = Contacts[index];
                IsEditing = false;
            }
            SaveContacts();
            CanExecuteCommands();
        }

        /// <summary>
        /// Добавление контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        [RelayCommand(CanExecute = nameof(CanAddContact))]
        private void AddContact(object parameter)
        {
            SelectedContact = null;
            SelectedContact = new ContactVM();
            IsAdding = true;
            CanExecuteCommands();
        }

        /// <summary>
        /// Редактирование контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        [RelayCommand(CanExecute = nameof(CanEditContact))]
        private void EditContact(object parameter)
        {
            BeforeEditingContact = SelectedContact;
            SelectedContact = new ContactVM(SelectedContact.Name, SelectedContact.PhoneNumber, SelectedContact.Email);
            IsEditing = true;
            CanExecuteCommands();
        }

        /// <summary>
        /// Удаление контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        [RelayCommand(CanExecute = nameof(CanRemoveContact))]
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
                        && !string.IsNullOrEmpty(SelectedContact.Email)
                        && !SelectedContact.HasErrors;
            }
            return true;
        }

        /// <summary>
        /// Проверка возможности добавления контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>True - доступно добавление контакта. False - недоступно.</returns>
        private bool CanAddContact(object parameter)
        {
            return !IsAdding && !IsEditing;
        }

        /// <summary>
        /// Проверка возможности редактирования контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter"Параметр.</param>
        /// <returns>True - доступно добавление контакта. False - недоступно.</returns>
        private bool CanEditContact(object parameter)
        {
            return SelectedContact != null && !IsAdding && !IsEditing;
        }

        /// <summary>
        /// Проверка возможности удаления контакта <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>True - доступно удаление контакта. False - недоступно.</returns>
        private bool CanRemoveContact(object parameter)
        {
            return SelectedContact != null && Contacts.Contains(SelectedContact);
        }

        /// <summary>
        /// Отслеживание вохможности нажатия кнопки Apply.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedContact_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            CanExecuteCommands();
        }

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="property">Название изменённого свойства.</param>
        private void CanExecuteCommands()
        {
            ApplyChangesCommand.NotifyCanExecuteChanged();
            AddContactCommand.NotifyCanExecuteChanged();
            RemoveContactCommand.NotifyCanExecuteChanged();
            EditContactCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/> и задаёт команды для работы с ним <see cref="RelayCommand"/>.
        /// </summary>
        public MainVM()
        {
            LoadContacts();

            if (Contacts.Count > 0)
            {
                SelectedContact = Contacts[0];
            }
            CanExecuteCommands();
        }
    }
}