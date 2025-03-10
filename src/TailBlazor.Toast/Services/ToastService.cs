using System;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using TailBlazor.Toast.Configuration;

namespace TailBlazor.Toast.Services
{
    public class ToastService : IToastService
    {

        /// <summary>
        /// Toast configuration options
        /// </summary>
        public ToastOptions _options { get; set; }

        /// <summary>
        /// ToastService parameterized constructor
        /// </summary>
        /// <param name="options">Toast configuration options</param>
        public ToastService(IOptions<ToastOptions> options)
        {
            _options = options.Value;
        }
        /// <summary>
        /// A event that will be invoked when showing a toast
        /// </summary>
        //public event Action<RenderFragment> OnShow;

        /// <summary>
        /// A event that will be invoked when showing a toast
        /// </summary>
        public event Action<ToastLevel, RenderFragment, string, Action> OnShow;

        /// <summary>
        /// Shows a toast using the fragment
        /// </summary>
        /// <param name="toast">RenderFragment of toast to display</param>
        public void ShowToast(RenderFragment toast) => OnShow?.Invoke(ToastLevel.Custom, toast, String.Empty, null);

        /// <summary>
        /// Shows a toast using the supplied settings
        /// </summary>
        /// <param name="level">Toast level to display</param>
        /// <param name="message">RenderFragment to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        /// <param name="onClick">Action to be executed on click</param>
        public void ShowToast(ToastLevel level, RenderFragment message, string heading = "", Action? onClick = null)
        {
            OnShow?.Invoke(level, message, heading, onClick);
        }

         /// <summary>
        /// Shows a toast using the supplied settings
        /// </summary>
        /// <param name="level">Toast level to display</param>
        /// <param name="message">Text to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        /// <param name="onClick">Action to be executed on click</param>
        public void ShowToast(ToastLevel level, string message, string heading = "", Action? onClick = null)
        {
            ShowToast(level, builder => builder.AddContent(0, message), heading, onClick);
        }

        /// <summary>
        /// Shows a success toast 
        /// </summary>
        /// <param name="message">Text to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        /// <param name="onClick">Action to be executed on click</param>
        public void ShowSuccess(string message, string heading = "", Action? onClick = null)
        {
            ShowToast(ToastLevel.Success, message, heading, onClick);
        }

        /// <summary>
        /// Shows a success toast 
        /// </summary>
        /// <param name="message">RenderFragment to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        /// <param name="onClick">Action to be executed on click</param>
        public void ShowSuccess(RenderFragment message, string heading = "", Action? onClick = null)
        {
            ShowToast(ToastLevel.Success, message, heading, onClick);
        }

        /// <summary>
        /// Shows a information toast 
        /// </summary>
        /// <param name="message">Text to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        /// <param name="onClick">Action to be executed on click</param>
        public void ShowInfo(string message, string heading = "", Action? onClick = null)
        {
            ShowToast(ToastLevel.Info, message, heading, onClick);
        }

        /// <summary>
        /// Shows a information toast 
        /// </summary>
        /// <param name="message">RenderFragment to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        /// <param name="onClick">Action to be executed on click</param>
        public void ShowInfo(RenderFragment message, string heading = "", Action? onClick = null)
        {
            ShowToast(ToastLevel.Info, message, heading, onClick);
        }

        /// <summary>
        /// Shows a warning toast 
        /// </summary>
        /// <param name="message">Text to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        /// <param name="onClick">Action to be executed on click</param>
        public void ShowWarning(string message, string heading = "", Action? onClick = null)
        {
            ShowToast(ToastLevel.Warning, message, heading, onClick);
        }

        /// <summary>
        /// Shows a warning toast 
        /// </summary>
        /// <param name="message">RenderFragment to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        /// <param name="onClick">Action to be executed on click</param>
        public void ShowWarning(RenderFragment message, string heading = "", Action? onClick = null)
        {
            ShowToast(ToastLevel.Warning, message, heading, onClick);
        }

        /// <summary>
        /// Shows a error toast 
        /// </summary>
        /// <param name="message">Text to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        /// <param name="onClick">Action to be executed on click</param>
        public void ShowError(string message, string heading = "", Action? onClick = null)
        {
            ShowToast(ToastLevel.Error, message, heading, onClick);
        }

        /// <summary>
        /// Shows a error toast 
        /// </summary>
        /// <param name="message">RenderFragment to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        /// <param name="onClick">Action to be executed on click</param>
        public void ShowError(RenderFragment message, string heading = "", Action? onClick = null)
        {
            ShowToast(ToastLevel.Error, message, heading, onClick);
        }
    }
}