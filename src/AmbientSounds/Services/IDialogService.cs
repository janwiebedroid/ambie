﻿using AmbientSounds.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmbientSounds.Services
{
    /// <summary>
    /// Interface for triggering a dialog
    /// or modal pop up.
    /// </summary>
    public interface IDialogService
    {
        /// <summary>
        /// Opens a settings dialog.
        /// </summary>
        Task OpenSettingsAsync();

        /// <summary>
        /// Opens the theme settings dialog.
        /// </summary>
        Task OpenThemeSettingsAsync();

        /// <summary>
        /// Opens a rename dialog.
        /// </summary>
        /// <param name="currentName">The current name use to pre-populate the field.</param>
        /// <returns>The raw value from the input text field. This can be the same as the currentName value.</returns>
        Task<string> RenameAsync(string currentName);

        /// <summary>
        /// Opens the premium dialog where users can purchase
        /// ambie plus.
        /// </summary>
        Task OpenPremiumAsync();

        /// <summary>
        /// Opens dialog regarding missing sounds.
        /// Returns true if user chooses to
        /// download missing sounds.
        /// </summary>
        Task<bool> MissingSoundsDialogAsync();

        /// <summary>
        /// Opens videos menu dialog.
        /// </summary>
        Task OpenVideosMenuAsync();

        /// <summary>
        /// Opens interruption dialog.
        /// </summary>
        Task<(double, string)> OpenInterruptionAsync();

        /// <summary>
        /// Opens dialog for the given history details.
        /// </summary>
        Task OpenHistoryDetailsAsync(FocusHistoryViewModel historyViewModel);

        /// <summary>
        /// Opens a dialog that will edit the prepopulated string.
        /// </summary>
        /// <param name="prepopulatedText">Text to prepopulate the UI.</param>
        /// <param name="maxSize">Optional max length for the string input.</param>
        /// <returns>
        /// Returns a real string if the operation was confirmed, the text was valid, and if the text was changed.
        /// </returns>
        Task<string?> EditTextAsync(string prepopulatedText, int? maxSize = null);
    }
}
