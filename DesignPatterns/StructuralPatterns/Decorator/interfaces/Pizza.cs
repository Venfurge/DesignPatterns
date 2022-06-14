namespace Decorator.interfaces
{
    internal abstract class Pizza
    {
        public abstract string Description { get; set; }
        public abstract double Price { get; set; }

        public virtual double GetPrice()
        {
            return Price;
        }

        public virtual List<string> GetDescriptions()
        {
            List<string> descriptionList = new List<string>();
            descriptionList.Add(Description);
            return descriptionList;
        }

        public string GetPrettieDescription()
        {
            string description = Description;

            List<string> descriptionDetails = GetDescriptions();
            List<string> prettiedDescriptions = descriptionDetails
                .Distinct()
                .Select(g => new 
                { 
                    Description = g, 
                    Count = descriptionDetails.Count(detail => detail == g) 
                })
                .Select(q => makePrettieDescription(q.Description, q.Count))
                .ToList();

            description = String.Join(", ", prettiedDescriptions);
            return description;
        }

        private string makePrettieDescription(string description, int count)
        {
            if (count < 0)
            {
                return "";
            }

            return count switch
            {
                0 => "",
                1 => description,
                2 => $"double {description}",
                3 => $"triple {description}",
                _ => $"{count}x {description}",
            };
        }
    }
}
