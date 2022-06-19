using TemplateMethod.interfaces;

namespace TemplateMethod.models
{
    internal class Pie : IMeal
    {
        public string Name { get; set; }

        public Pie(string name)
            => (Name) = (name);
    }
}
