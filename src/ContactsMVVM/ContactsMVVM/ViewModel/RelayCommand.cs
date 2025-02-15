using System;
using System.Windows.Input;

namespace ContactsMVVM.ViewModel
{
    /// <summary>
    /// Класс комманд. Реализация интерфейса <see cref="ICommand"/>.
    /// </summary>
    internal class RelayCommand : ICommand
    {
        /// <summary>
        /// Делегат <see cref="Action"/>.
        /// </summary>
        private Action<object> _execute;

        /// <summary>
        /// Делегат <see cref="Func{Object, bool}".
        /// </summary>
        private Func<object, bool> _canExecute;

        /// <summary>
        /// Событие <see cref="EventHandler"/>.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Создаёт команду для выполнения.
        /// </summary>
        /// <param name="execute">Метод логики выполнения.</param>
        /// <param name="canExecute">Метод проверки возможности выполнения.</param>
        /// <exception cref="ArgumentNullException">Исключение случае если отстутствия логики выполнения.</exception>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        /// <summary>
        /// Проверка возможности выполнения команды.
        /// </summary>
        /// <param name="parameter">Метод проверки.</param>
        /// <returns>True - можно выполнить. False - нельзя выполнить.</returns>
        public bool CanExecute(object parameter)
        {
            return this._canExecute == null || this._canExecute(parameter);
        }

        /// <summary>
        /// Выполнение команды.
        /// </summary>
        /// <param name="parameter">Метод выполнения.</param>
        public void Execute(object parameter)
        {
            this._execute(parameter);
        }

        /// <summary>
        /// Вызывает событие CanExecuteChanged.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}