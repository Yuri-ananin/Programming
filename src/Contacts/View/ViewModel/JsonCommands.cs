using System;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Команды для сохранения и загрузки данных. <see cref="ICommand"/>.
    /// </summary>
    class JsonCommands : ICommand
    {
        /// <summary>
        /// Делегат <see cref="Action"/>.
        /// </summary>
        private readonly Action<object> _executeAction;

        /// <summary>
        /// Вызов действия.
        /// </summary>
        /// <param name="parameter">Параметр команды</param>.
        public void Execute(object parameter) => _executeAction(parameter);

        /// <summary>
        /// Устанавливает возможность выполнения команды.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        /// <returns>True - может. False - не может.</returns>
        public bool CanExecute(object? parameter) => true;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="JsonCommands"/> для выполнения действия.
        /// </summary>
        /// <param name="executeAction">Действие, которое будет выполнено.</param>
        public JsonCommands(Action<object> executeAction)
        {
            _executeAction = executeAction;
        }

        /// <summary>
        /// Событие, вызываемое при изменении условия на выполнение команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }
        }
    }
}