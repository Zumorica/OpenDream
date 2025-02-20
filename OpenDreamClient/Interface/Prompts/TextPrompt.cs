﻿using OpenDreamShared.Dream.Procs;
using System.Windows;
using System.Windows.Controls;

namespace OpenDreamClient.Interface.Prompts {
    class TextPrompt : PromptWindow {
        public TextPrompt(int promptId, string message) : base(promptId, message) { }

        protected override Control CreatePromptControl() {
            return new TextBox();
        }

        protected override void OkButton_Click(object sender, RoutedEventArgs e) {
            FinishPrompt(DMValueType.Text, ((TextBox)PromptControl).Text);
        }
    }
}
