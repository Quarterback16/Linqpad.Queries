<Query Kind="Statements" />

var trans = new List<Transaction>
{
   new Transaction("CD","4","SF","QB","Joe Montana","79","IN"),
   new Transaction("CD","16","TB","QB","Jack Thompson","1","IN"),
   new Transaction("CD","32","WR","RB","John Riggins","79","IN"),
   new Transaction("CD","41","LA","RB","Marcus Allen","59","IN"),
   new Transaction("CD","35","SS","RB","Curt Warner","39","IN"),
   new Transaction("CD","129","DC","RB","Timmy Newsome","1","IN"),
   new Transaction("CD","97","MD","WR","Nat Moore","14","IN"),
   new Transaction("CD","85","KC","WR","Carlos Carson","6","IN"),
   new Transaction("CD","88","GB","WR","John Jefferson","2","IN"),
   new Transaction("CD","128","CH","WR","Dennis McKinnon","1","IN"),
   new Transaction("CD","191","NE","WR","Stanley Morgan","1","IN"),
   new Transaction("CD","178","LA","WR","Dokie Williams","1","IN"),
   new Transaction("CD","165","DC","WR","Butch Johnson","1","IN"),
   new Transaction("CD","131","WR","KK","Mark Moseley","79","IN"),
   new Transaction("CD","132","NG","KK","Ali Haji-Shiekh","39","IN"),
   new Transaction("CD","140","LA","KK","Chris Bahr","14","IN"),
   new Transaction("DD","1","GB","QB","Lynn Dickey","125","IN"),
   new Transaction("DD","192","NG","QB","Jeff Hostetler","1","IN"),
   new Transaction("DD","46","KC","RB","Theotis Brown","26","IN"),
   new Transaction("DD","50","DC","RB","Ron Springs","6","IN"),
   new Transaction("DD","77","GB","TE","Paul Coffman","45","IN"),
   new Transaction("DD","84","SR","TE","Doug Marsh","30","IN"),
   new Transaction("DD","78","MD","WR","Mark Duper","35","IN"),
   new Transaction("DD","81","SF","WR","Dwight Clark","35","IN"),
   new Transaction("DD","86","NJ","WR","Wesley Walker","35","IN"),
   new Transaction("DD","108","SR","WR","Pat Tilley","12","IN"),
   new Transaction("DD","190","KC","WR","Stephone Paige","12","IN"),
   new Transaction("DD","107","DC","WR","Drew Pearson","1","IN"),
   new Transaction("DD","136","PS","KK","Gary Anderson","30","IN"),
   new Transaction("DD","138","SF","KK","Ray Wersching","20","IN"),
   new Transaction("LL","8","SR","QB","Neil Lomax","28","IN"),
   new Transaction("LL","17","SS","QB","Dave Krieg","22","IN"),
   new Transaction("LL","23","CH","QB","Jim McMahon","18","IN"),
   new Transaction("LL","59","BC","RB","Curtis Dickey","31","IN"),
   new Transaction("LL","63","TB","RB","James Wilder","15","IN"),
   new Transaction("LL","186","DB","RB","Sammy Winder","11","IN"),
   new Transaction("LL","","52","DL","RB James","Jones","IN"),
   new Transaction("LL","","61","SF","RB Wendell","Tyler","IN"),
   new Transaction("LL","91","CL","TE","Ozzie Newsome","55","IN"),
   new Transaction("LL","100","NE","TE","Derrick Ramsey","18","IN"),
   new Transaction("LL","92","HO","WR","Tim Smith","33","IN"),
   new Transaction("LL","160","SD","WR","Charlie Joiner","33","IN"),
   new Transaction("LL","101","NG","WR","Earnest Gray","26","IN"),
   new Transaction("LL","105","TB","WR","Kevin House","21","IN"),
   new Transaction("LL","","94","KC","WR Henry","Marshall","IN"),
   new Transaction("LL","142","MD","KK","Uwe Von Schamann","1","IN"),   
   new Transaction("SR","12","LA","QB","Jim Plunkett","48","IN"),
   new Transaction("SR","22","CI","QB","Ken Anderson","48","IN"),
   new Transaction("SR","10","AF","QB","Steve Bartkowski","16","IN"),
   new Transaction("SR","51","CH","RB","Walter Payton","58","IN"),
   new Transaction("SR","43","DC","RB","Tony Dorsett","48","IN"),
   new Transaction("SR","54","SR","RB","Ottis Anderson","25","IN"),
   new Transaction("SR","189","NG","RB","Joe Morris","15","IN"),
   new Transaction("SR","96","DC","TE","Doug Cosbie","30","IN"),
   new Transaction("SR","120","SF","TE","Russ Francis","25","IN"),
   new Transaction("SR","82","GB","WR","James Lofton","40","IN"),
   new Transaction("SR","80","WR","WR","Charlie Brown","38","IN"),
   new Transaction("SR","122","SF","WR","Freddie Solomon","15","IN"),
   new Transaction("SR","114","AF","WR","Billy Johnson","12","IN"),
   new Transaction("SR","167","PE","WR","Harold Carmichael","12","IN"),
   new Transaction("SR","148","NS","KK","Morten Andersen","39","IN"),
   new Transaction("SR","146","DB","KK","Rich Karlis","36","IN"),
   new Transaction("SR","151","NJ","KK","Pat Leahy","9","IN"),
   new Transaction("CD","5","BB","QB","Joe Ferguson","17","IN"),
   new Transaction("CD","6","CL","QB","Brian Sipe","17","IN"),
   new Transaction("CD","27","DB","QB","Steve DeBerg","8","IN"),
   new Transaction("CD","33","LR","RB","Eric Dickerson","122","IN"),
   new Transaction("CD","37","SD","RB","Chuck Muncie","8","IN"),
   new Transaction("CD","38","CL","RB","Mike Pruitt","8","IN"),
   new Transaction("CD","66","PS","RB","Frank Pollard","7","IN"),
   new Transaction("CD","56","NS","RB","George Rogers","5","IN"),
   new Transaction("CD","57","BC","RB","Randy McMillan","5","IN"),
   new Transaction("CD","75","LA","TE","Todd Christensen","75","IN"),
   new Transaction("CD","161","LR","TE","Mike Barber","1","IN"),
   new Transaction("CD","74","PE","WR","Mike Quick","78","IN"),
   new Transaction("CD","76","SS","WR","Steve Largent","60","IN"),
   new Transaction("CD","109","LR","WR","George Farmer","1","IN"),
   new Transaction("CD","124","BC","WR","Bernard Henry","1","IN"),
   new Transaction("CD","137","KC","KK","Nick Lowery","24","IN"),
   new Transaction("CD","141","DC","KK","Rafael Septien","6","IN"),
   new Transaction("CD","139","SR","KK","Neil O'Donoghue","3","IN"),
   new Transaction("CG","2","DC","QB","Danny White","61","IN"),
   new Transaction("CG","7","KC","QB","Bill Kenney","31","IN"),
   new Transaction("CG","48","AF","RB","William Andrews","107","IN"),
   new Transaction("CG","87","BB","RB","Joe Cribbs","75","IN"),
   new Transaction("CG","39","NE","RB","Tony Collins","29","IN"),
   new Transaction("CG","42","NS","RB","Wayne Wilson","9","IN"),
   new Transaction("CG","90","DL","TE","Ulysses Norris","21","IN"),
   new Transaction("CG","162","CH","TE","Emery Moorehead","5","IN"),
   new Transaction("CG","164","NS","TE","Hoby Brenner","1","IN"),
   new Transaction("CG","73","SR","WR","Roy Green","85","IN"),
   new Transaction("CG","83","CH","WR","Willie Gault","41","IN"),
   new Transaction("CG","110","LA","WR","Cliff Branch","1","IN"),
   new Transaction("CG","111","PS","WR","Calvin Sweeney","1","IN"),
   new Transaction("CG","144","GB","KK","Jan Stenerud","25","IN"),
   new Transaction("CG","154","AF","KK","Mick Luckhurst","15","IN"),
   new Transaction("RR","14","MD","QB","Dan Marino","103","IN"),
   new Transaction("RR","18","NE","QB","Steve Grogan","16","IN"),
   new Transaction("RR","185","NG","QB","Phil Simms","3","IN"),
   new Transaction("RR","45","SF","RB","Roger Craig","55","IN"),
   new Transaction("RR","47","AF","RB","Gerald Riggs","27","IN"),
   new Transaction("RR","34","CI","RB","Pete Johnson","22","IN"),
   new Transaction("RR","40","MV","RB","Ted Brown","17","IN"),
   new Transaction("RR","99","KC","TE","Willie Scott","5","IN"),
   new Transaction("RR","106","WR","WR","Art Monk","44","IN"),
   new Transaction("RR","102","CI","WR","Cris Collinsworth","44","IN"),
   new Transaction("RR","193","PS","WR","John Stallworth","8","IN"),
   new Transaction("RR","184","LR","WR","Henry Ellard","4","IN"),
   new Transaction("RR","98","LR","WR","Drew Hill","2","IN"),
   new Transaction("RR","134","MV","KK","Benny Ricardo","18","IN"),
   new Transaction("RR","147","CH","KK","Bob Thomas","1","IN"),
   new Transaction("SF","13","SD","QB","Dan Fouts","42 ","IN"),
   new Transaction("SF","3","WR","QB","Joe Thiesmann","15 ","IN"),
   new Transaction("SF","31","DB","QB","John Elway","15 ","IN"),
   new Transaction("SF","11","PE","QB","Ron Jaworski","15 ","IN"),
   new Transaction("SF","49","DL","RB","Billy Sims","25 ","IN"),
   new Transaction("SF","36","HO","RB","Earl Campbell","23 ","IN"),
   new Transaction("SF","188","NJ","RB","Freeman McNeil","15 ","IN"),
   new Transaction("SF","95","WR","RB","Joe Washington","15 ","IN"),
   new Transaction("SF","130","WR","TE","Clint Didier","25 ","IN"),
   new Transaction("SF","79","SD","TE","Kellen Winslow","19 ","IN"),
   new Transaction("SF","121","HO","TE","Chris Dressel","5 ","IN"),
   new Transaction("SF","127","MD","TE","Dan Johnson","5 ","IN"),
   new Transaction("SF","89","DC","WR","Tony Hill","35 ","IN"),
   new Transaction("SF","93","AF","WR","Stacey Bailey","25 ","IN"),
   new Transaction("SF","103","DB","WR","Steve Watson","25 ","IN"),
   new Transaction("SF","187","MD","WR","Mark Clayton","25 ","IN"),
   new Transaction("SF","104","SD","WR","Wes Chandler","15 ","IN"),
   new Transaction("SF","126","AF","WR","Floyd Hodge","5 ","IN"),
   new Transaction("SF","133","BC","KK","Raul Allegre","45 ","IN"),
   new Transaction("SF","145","SS","KK","Norm Johnson","45 ","IN"),   
};


Console.WriteLine("[");
foreach(var t in trans)
{
  Console.Write("   {");
   Console.Write( $@"
        ""fteam"": ""{t.Fteam}""," );
   Console.Write( $@"
        ""num"": ""{t.Id}""," );
   Console.Write( $@"
        ""team"": ""{t.ProTeam}""," );		
   Console.Write( $@"
        ""player"": ""{t.Player}""," );
   Console.Write( $@"
        ""pos"": ""{t.Pos}""," );
   Console.Write( $@"
        ""price"": ""{t.Price}""," );		
   Console.WriteLine( $@"
        ""trans"": ""{t.Direction}""" );	
   Console.WriteLine("   },");		
}

Console.WriteLine("]");

}

public struct Transaction {
  public string Fteam;
  public string Id;
  public string Player;
  public string ProTeam;
  public string Pos;
  public string Price;
  public string Direction;
  
  public Transaction(
      string fteam,
	  string id,
	  string proteam,
	  string pos,
	  string player,
	  string price,
	  string direction) 
  {
	Fteam = fteam;
	Id = id;
	Player = player;
	ProTeam = proteam;
	Pos = pos;
	Price = price;
	Direction = direction;
  }  
