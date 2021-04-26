using Content.Client.UserInterface.Stylesheets;
using Robust.Client.UserInterface.Controls;
using Robust.Shared.Maths;

namespace Content.Client.UserInterface
{
    public class NanoHeading : Container
    {
        private readonly Label _label;
        private readonly PanelContainer _panel;

        public NanoHeading()
        {
            _panel = new PanelContainer
            {
                Children = {(_label = new Label
                {
                    StyleClasses = {StyleNano.StyleClassLabelHeading}
                })}
            };
            AddChild(_panel);

            HorizontalAlignment = HAlignment.Left;
        }

        public string? Text
        {
            get => _label.Text;
            set => _label.Text = value;
        }
    }
}