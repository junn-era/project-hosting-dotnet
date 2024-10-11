using ProjectHosting.Models;

List<Person> guests = new List<Person>();

Person p1 = new Person(name: "Hóspede 1");
Person p2 = new Person(name: "Hóspede 2");
Person p3 = new Person(name: "Hóspede 3");
Person p4 = new Person(name: "Hóspede 4");
Person p5 = new Person(name: "Hóspede 5");
Person p6 = new Person(name: "Hóspede 6");
Person p7 = new Person(name: "Hóspede 7");
Person p8 = new Person(name: "Hóspede 8");
Person p9 = new Person(name: "Hóspede 9");
Person p10 = new Person(name: "Hóspede 10");
Person p11 = new Person(name: "Hóspede 11");
Person p12 = new Person(name: "Hóspede 12");

guests.Add(p1);
guests.Add(p2);
guests.Add(p3);
guests.Add(p4);
guests.Add(p5);
guests.Add(p6);
guests.Add(p7);
guests.Add(p8);
guests.Add(p9);
guests.Add(p10);
guests.Add(p11);
guests.Add(p12);

Suite suite = new Suite(suiteType: "Premium", capacity: 2, nightlyRate: 30);

Booking booking = new Booking(nightsBooked: 10);
booking.RegisterSuite(suite);
booking.RegisterGuests(guests);

Console.WriteLine($"Hóspedes: {booking.GetGuestsQuantity()}");
Console.WriteLine($"Valor diária: {booking.CalcNightlyRate()}");
