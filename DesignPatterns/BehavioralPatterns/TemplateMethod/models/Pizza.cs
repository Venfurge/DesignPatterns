using TemplateMethod.interfaces;

namespace TemplateMethod.models
{
    internal class Pizza : IMeal
    {
        public string Name { get; set; }

        public Pizza(string name)
            => (Name) = (name);
    }
}
