<Query Kind="Program">
  <Connection>
    <ID>8ea495ad-ca39-4349-8d00-31c8ed3f932d</ID>
    <Persist>true</Persist>
    <Server>WDE308498</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAADkbo9YIwq0O9dh97H8g4fAAAAAACAAAAAAADZgAAwAAAABAAAADFVPSWENNB6erAwv/Aw1UHAAAAAASAAACgAAAAEAAAACroxLLjTg4HhUbYuuhRI9sQAAAAQPrkJ3kFe311Ov5cf7At+hQAAAB0JMSgkJEym9H4Fpgd1541JG9C4g==</Password>
    <Database>Northwind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

void Main()
{
   AbstractHouseClass objHouse = new AbstractHouseClass();

   objHouse.purposeofVisit();
   objHouse.NoofGuestwillvisit();
   Console.ReadLine();
}

abstract class GuestVist
    {
        public abstract void purposeofVisit();  // Abstract Method 

        public virtual void NoofGuestwillvisit()  // Virtual Method
        {
            Console.WriteLine("Total 5 Guest will Visit your Home");
        }
    }
	
    class AbstractHouseClass : GuestVist
    {
        public override void purposeofVisit()  // Abstract method Override
        {
            Console.WriteLine("Abstract just for a Meetup and spend some time ");
        }

        //public override void NoofGuestwillvisit() // Virtual method override
        //{
        //    Console.WriteLine("Total 20 Guest Visited our Home");
        //}
	}