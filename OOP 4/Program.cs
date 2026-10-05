namespace OOP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions
            // Q1  Abstraction

            // a)  What is Abstraction in Object-Oriented Programming?
            // Abstraction means hiding the complex implementation details of an object and showing only the important parts that the user needs to use.
            // It helps reduce complexity and makes the code easier to understand, maintain, and reuse.

            //b)  Why is abstraction considered one of the four pillars of OOP ?
            //because it allows us to separate what an object does from how it is implemented internally


            // Q2  Abstract Classes vs. Interfaces

            //a)  What is the difference between an Abstract Class and an Interface?
            // Abstract class can contain both abstract and non abstract methods, while an interface mainly defines what a class should do without providing implementation.
            // ,class can inherit from only one abstract class, but it can implement multiple interfaces.

            //b)  When would you choose an Interface instead of an Abstract Class?
            //when different classes need to have the same behavior, even if they are not related to each other. It also gives us more flexibility because a class can implement more than one interface.

            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            //NO , YES 

            #endregion

            #region Practical Questions

            #region Main() Checklist a,b,c,d     
            DeliveryAddress address = new DeliveryAddress("123 Main St", "Alexandria", 21500);

            StandardShipment standard = new StandardShipment("SH001", "Books", 3.0m, 50.0m, address);

            ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 1.5m, 60.0m, address, 20.0m);

            InternationalShipment international = new InternationalShipment("SH003", "Laptop", 2.5m, 100.0m, address, "Canada", 150.0m);

            DeliveryCenter center = new DeliveryCenter("Alexandria Hub");
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);


            #endregion

            #region Main() Checklist e
            Console.WriteLine("Delivery Center");
            Console.WriteLine();

            center.PrintAllShipments();

            #endregion

            #region Main() Checklist f

            Console.WriteLine("Tracking Status");
            Console.WriteLine();

            center.PrintTrackingStatuses();

            #endregion

            #region Main() Checklist g.

            Console.WriteLine("Insurance");
            Console.WriteLine();

            Console.Write("Standard Shipment Insurance : ");
            DeliveryReport.PrintInsurance(standard);

            Console.Write("Express Shipment Insurance  : ");
            DeliveryReport.PrintInsurance(express);

            Console.Write("International Shipment Insurance : ");
            DeliveryReport.PrintInsurance(international);

            #endregion

            #region Main() Checklist h.

            Console.WriteLine("ITrackable Array - Tracking Statuses");

            ITrackable[] trackableShipments = new ITrackable[] { standard, express, international };

            foreach (ITrackable trackable in trackableShipments)
            {
                Console.WriteLine(trackable.GetTrackingStatus());
            }
            #endregion

            #region Main() Checklist i.

            Console.WriteLine("IInsurable Array - Insurance Values");

            IInsurable[] insurableShipments = new IInsurable[] { standard, express, international };

            foreach (IInsurable insurable in insurableShipments)
            {
                Console.WriteLine($"Insurance Value: {insurable.CalculateInsurance()} EGP");
            }

            #endregion

            #endregion
        }
    }
}

