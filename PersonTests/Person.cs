namespace PersonTests
{
    /// <summary>
    /// Represents one person saving their name.
    /// </summary>
    public class Person : IDisplayable, IResettable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// Constructor for a person optionally adding their name.
        /// </summary>
        /// <param name="name">Person's name, empty by default.</param>
        public Person(string name = "")
        {
            this.Name = name.Trim();
        }

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Returns a string that represents the person.
        /// </summary>
        /// <returns>String that represents the person.</returns>
        public override string ToString()
        {
            return this.Name;
        }

        /// <summary>
        /// This method will activiate and display the name held in the name paramater.
        /// </summary>
        public void Display()
        {
            MessageBox.Show("My name is " + this.Name);
        }

        /// <summary>
        /// This Method will take the Name held in memory and clear it.
        /// </summary>
        public void Reset()
        {
            this.Name = string.Empty;
        }
    }
}
