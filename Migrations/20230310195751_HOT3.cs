using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCHOT2.Migrations
{
    /// <inheritdoc />
    public partial class HOT3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerStreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "CustomerCity", "CustomerFirstName", "CustomerLastName", "CustomerPhoneNumber", "CustomerState", "CustomerStreetAddress", "CustomerZipCode" },
                values: new object[,]
                {
                    { 1, "Redmond", "Suzanne", "Viescas", "425-555-2686", "WA", "15127 NE 24th, #383", "98052" },
                    { 2, "Duvall", "William", "Thompson", "425-555-2681", "WA", "122 Spring River Drive", "98019" },
                    { 3, "Auburn", "Gary", "Hallmark", "253-555-2676", "WA", "Route 2 Road", "98002" },
                    { 4, "Houston", "Robert", "Brown", "713-555-2491", "TX", "672 Lamont Ave", "77201" },
                    { 5, "Redmond", "Dean", "McCrae", "425-555-2506", "WA", "4110 Redmond Rd.", "98052" },
                    { 6, "Redmond", "John", "Viescas", "425-555-2511", "WA", "15127 NE 24th, #383", "98052" },
                    { 7, "Portland", "Mariya", "Sergienko", "503-555-2526", "OR", "901 Pine Avenue", "97208" },
                    { 8, "San Diego", "Neil", "Patterson", "619-555-2541", "CA", "233 West Valley Hwy", "92199" },
                    { 9, "Seattle", "Andrew", "Cencini", "206-555-2601", "WA", "507 - 20th Ave. E. Apt. 2A", "98105" },
                    { 10, "Austin", "Angel", "Kennedy", "512-555-2571", "TX", "667 Red River Road", "78710" },
                    { 11, "Woodinville", "Alaina", "Hallmark", "425-555-2631", "WA", "Route 2, Box 203B", "98072" },
                    { 12, "Bellevue", "Liz", "Keyser", "425-555-2556", "WA", "13920 S.E. 40th Street", "98006" },
                    { 13, "San Diego", "Rachel", "Patterson", "619-555-2546", "CA", "2114 Longview Lane", "92199" },
                    { 14, "Palm Springs", "Sam", "Abolrous", "760-555-2611", "CA", "611 Alpine Drive", "92263" },
                    { 15, "Chico", "Darren", "Gehring", "530-555-2616", "CA", "2601 Seaview Lane", "95926" },
                    { 16, "Salem", "Jim", "Wilson", "503-555-2636", "OR", "101 NE 88th", "97301" },
                    { 17, "Medford", "Manuela", "Seidel", "541-555-2641", "OR", "66 Spring Valley Drive", "97501" },
                    { 18, "Fremont", "David", "Smith", "510-555-2646", "CA", "311 20th Ave. N.E.", "94538" },
                    { 19, "Glendale", "Zachary", "Ehrlich", "818-555-2721", "CA", "12330 Kingman Drive", "91209" },
                    { 20, "Bellevue", "Joyce", "Bonnicksen", "425-555-2726", "WA", "2424 Thames Drive", "98006" },
                    { 21, "Dallas", "Estella", "Pundt", "972-555-9938", "TX", "2500 Rosales Lane", "75260" },
                    { 22, "Long Beach", "Caleb", "Viescas", "562-555-0037", "CA", "4501 Wetland Road", "90809" },
                    { 23, "Seattle", "Julia", "Schnebly", "206-555-9936", "WA", "2343 Harmony Lane", "99837" },
                    { 24, "El Paso", "Mark", "Rosales", "915-555-2286", "TX", "323 Advocate Lane", "79915" },
                    { 25, "El Paso", "Maria", "Patterson", "915-555-2291", "TX", "3445 Cheyenne Road", "79915" },
                    { 26, "San Antonio", "Kirk", "DeGrasse", "210-555-2311", "TX", "455 West Palm Ave", "78284" },
                    { 27, "Portland", "Luke", "Patterson", "503-555-2316", "OR", "877 145th Ave SE", "97208" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "ProductDescLong", "ProductDescShort", "ProductImage" },
                values: new object[] { "This is a fun flowy trail! The trail starts with a test- a skinny with a 2 ft. The area is mostly wooded but there are several places that offer spectacular views.", "ATB Wheels", "~/images/01-AeroFlo-ATB-Wheels.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "ProductDescLong", "ProductDescShort", "ProductImage" },
                values: new object[] { "There is no preferred direction and the trail is a great connector for several other fun loops. Two wheel drifting is likely if you have speed.", "85-T Glasses", "~/images/02-Clear-Shade-85-T-Glasses.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "ProductDescLong", "ProductDescShort", "ProductImage" },
                values: new object[] { "Rowdy little downhill/freeride track. 16 Mile Summer Trail was initially a rugged singletrack DH trail maintained by local builders since 2008.", "Road Warrior Wheels", "~/images/03-Cosmic-Elite-Road-Warrior-Wheels.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "ProductDescLong", "ProductDescShort", "ProductImage" },
                values: new object[] { "The State of Alaska installed a more user friendly course in 2012. Mostly dry with some small mud puddles. The trails are well drained and suitable for riding when wet.", "Repair Stand", "~/images/04-Cycle-Doc-Pro-Repair-Stand.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "ProductDescLong", "ProductDescShort", "ProductImage" },
                values: new object[] { "It packs in a lot of excitement in a short amount of time. IMO it is a better ride to turn around and follow the same trail down. Removable by hand saw.", "Floor Pump", "~/images/05-Dog-Ear-Aero-Flow-Floor-Pump.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ProductDescLong", "ProductDescShort", "ProductImage", "ProductName", "ProductPrice", "ProductQty" },
                values: new object[,]
                {
                    { 6, 1, "This is just a brute of a climb. Short and fast, with a few small jumps and some loose rocks to keep you on your toes.", "Cycle Computer", "~/images/06-Dog-Ear-Cycle-Computer.jpg", "Dog Ear Cycle Computer", 75m, 20 },
                    { 7, 1, "There may be an optional dropspot 1/2 way down. The turns may be smooth berms that will be easy riding. It has few real technical features.", "Helmet Mirrors", "~/images/07-Dog-Ear-Helmet-Mount-Mirror.jpg", "Dog Ear Helmet Mount Mirrors", 7.45m, 12 },
                    { 8, 1, "Since being redesigned, it is a lot of fun to ride this glassy smooth and generally well-bermed trail. Logs embedded in the trail have been installed.", "Grip Gloves", "~/images/08-Dog-Ear-Monster-Grip-Gloves.jpg", "Dog Ear Monster Grip Gloves", 15m, 30 },
                    { 9, 2, "Installed to signal technical terrain. This trail begins with a small pump section with two smaller jumps and a third larger hip jump.", "Mountain Bike", "~/images/09-Eagle-FS-3-Mountain-Bike.jpg", "Eagle FS-3 Mountain Bike", 1800m, 8 },
                    { 10, 4, "Fun! Chewed up, lots of braking bumps, but still fun. Winding trail with dips, climbs and descents. The turns are all smooth berms and easy to ride.", "Clipless Pedals", "~/images/10-Eagle-SA-120-Clipless-Pedals.jpg", "Eagle SA-120 Clipless Pedals", 139.95m, 20 },
                    { 11, 1, "Easy to ride and not wash out. This new trail flows well and has multiple banked berms and small jumps that wind down the mountainside.", "Cycling Helmet", "~/images/11-Glide-O-Matic-Cycling-Helmet.jpg", "Glide-O-Matic Cycling Helmet", 125m, 24 },
                    { 12, 2, "MBoSC has partnered with land manager California Department of Forestry and Fire Protection (CAL FIRE) to build a four mile flow trail in Soquel Demonstration State Forest (SDSF).", "Mountain Bike", "~/images/12-GT-RTS-2-Mountain-Bike.jpg", "GT RTS-2 Mountain Bike", 1650m, 5 },
                    { 13, 1, "Large group of trees down on northern section of trail, between buckhorn and club gap. There is no preferred direction and the trail is a great connector for several other fun loops.", "Panniers", "~/images/13-HP-Deluxe-Panniers.jpg", "HP Deluxe Panniers", 39m, 10 },
                    { 14, 1, "This area has a high density of trails for all ability levels and serves as the unofficial hub of mountain bike activity in the South Shore.", "Helmet", "~/images/14-King-Cobra-Helmet.jpg", "King Cobra Helmet", 139m, 30 },
                    { 15, 4, "Mountain bike activity in the South Shore. By the end of the 45-50 miles youll be plenty tired from the constant up and down nature of Mana Road.", "Kool Breeze Rocket Top Jersey", "~/images/15-Kool-Breeze-Rocket-Top-Jersey.jpg", "Kool Breeze Rocket Top Jersey", 4.99m, 40 },
                    { 16, 1, "16 Mile Summer Trail was initially a rugged singletrack DH trail maintained by local builders since 2008, the State of Alaska installed a more user friendly course in 2012.", "2000 U-Lock", "~/images/16-Kryptonite-Advanced-2000-U-Lock.jpg", "Kryptonite Advanced 2000 U-Lock", 50m, 20 },
                    { 17, 1, "Third Divide makes up part of the classic Downieville downhill route. A little overgrown on the seward side, but totlaly manageable.", "U-Lock", "~/images/17-Nikoma-Lok-Tight-U-Lock.jpg", "Nikoma Lok-Tight U-Lock", 33m, 12 },
                    { 18, 4, "Overgrown on the seward side, but totlaly manageable. Trail full of berms and fun features! But this trail does not relent for one second.", "ATB Pedal", "~/images/18-Proformance-ATB-All-Terrain-Pedal.jpg", "ProFormance ATB All-Terrain Pedal", 28m, 40 },
                    { 19, 4, "It doesnt get much use though so is sometimes a bit overgrown. Out here you will find the most legal features including log rides.", "Toe Klips", "~/images/19-ProFormance-Toe-Klips-2G.jpg", "ProFormance Toe Klips 2G", 28m, 40 },
                    { 20, 1, "Jumps and rock rolls in South Tahoe including the new jumps, berms, rollers and hips TAMBA and SBTS built in 2014. As the valley begins to close", "Dillo Shades", "~/images/20-Pro-Sport-Dillo-Shades.jpg", "Pro-Sport Dillo Shades", 82m, 18 },
                    { 21, 5, "The route transitions to a section of open forest. Trail contains a rope-suspended ladder bridge, elevated bridges and a long-straight skinny.", "Hitch Pack", "~/images/21-Road-Warrior-Hitch-Pack.jpg", "Road Warrior Hitch Pack", 175m, 6 },
                    { 22, 4, "Elevated bridges and a long-straight skinny. This new trail flows well and has multiple banked berms and small jumps that wind down the mountainside.", "SC Brakes", "~/images/22-Shinoman-105-SC-Brakes.jpg", "Shinoman 105 SC Brakes", 23.50m, 16 },
                    { 23, 4, "The trail is somewhat wide for singletrack and a bit technical with roots and rocks. Several high speed, low risk sections take you down the sandy open trail.", "TX-30 Pedal", "~/images/23-Shinoman-Deluxe-TX-30-Pedal.jpg", "Shinoman Deluxe TX-30 Pedal", 45m, 60 },
                    { 24, 4, "The sandy open trail for some of the most fun downhills in the area. Lost Lake starts at its namesake trailhead. Several high speed, low risk sections take you down the sandy open trail", "Headset", "~/images/24-Shinoman-Dura-Ace-Headset.jpg", "Shinoman Dura-Ace Headset", 67.50m, 20 },
                    { 25, 3, "Take you down the sandy open trail for some of the most fun downhills in the area. Ridgeline is a crown jewel of Dupont State Recreational Forest.", "Pants", "~/images/25-StaDry-Cycling-Pants.jpg", "StaDry Cycling Pants", 69m, 22 },
                    { 26, 1, "You now have to ride down an asphalt trail and cut off onto a gravel trail before getting back to the old single track. Watch that you dont overshoot the switchback", "Bike Rack", "~/images/26-TransPort-Bicycle-Rack.jpg", "TransPort Bicycle Rack", 27m, 14 },
                    { 27, 2, "Stay the black diamond descent - the blue route was completely overgrown. This was a legitimate expert trail, but much difficulty can be mitigated slowing down, picking your line carefully.", "Mountain Bike", "~/images/27-Trek-9000-Mountain-Bike.jpg", "Trek 9000 Mountain Bike", 1200m, 6 },
                    { 28, 1, "The start of the dirt road is marked on the Google Map directions on this page. Im slow and a little chicken top hit some of the gap jumps but this was super fun.", "Gloves", "~/images/28-True-Grip-Competition-Gloves.jpg", "True Grip Competition Gloves", 22m, 20 },
                    { 29, 6, "Logs embedded in the trail have been installed to signal technical terrain. Out of the parking lot, take your first left. Trail contains a rope-suspended ladder bridge.", "Tires", "~/images/29-Turbo-Twin-Tires.jpg", "Turbo Twin Tires", 29m, 18 },
                    { 30, 5, "Elevated bridges and a long-straight skinny. Having gotten that out of the way, the Mana Road ride is absolutely beautiful and worth the ride.", "Car Rack", "~/images/30-Ultimate-Export-2G-Car-Rack.jpg", "Ultimate Export 2G Car Rack", 180m, 8 },
                    { 31, 6, "Road ride is absolutely beautiful and worth the ride. Watch that you dont overshoot the switchback to stay on the black diamond descent - the blue route is completely overgrown.", "Tires", "~/images/31-Ultra-2K-Competition-Tire.jpg", "Ultra-2K Competition Tire", 34m, 22 },
                    { 32, 3, "Super loose after second intersection. The bottom portion of the trail is fast, loose and tight. Landings are getting a little rotted but the overall condition is good.", "Rain Jacket", "~/images/32-Ultra-Pro-Rain-Jacket.jpg", "Ultra-Pro Rain Jacket", 85m, 30 },
                    { 33, 4, "The overall condition is good. The start of the dirt road is marked on the Google Map directions on this page. Pretty dry and fast.", "Tires", "~/images/33-Victoria-Pro-All-Weather-Tires.jpg", "Victoria Pro All Weather Tires", 54.95m, 20 },
                    { 34, 1, "At almost 20 miles with almost everything tahoe has to offer. I need to learn how to jump! By the end of the 45-50 miles youll be plenty tired from the constant up and down.", "Computer", "~/images/34-Viscount-C-500-Wireless-Bike-Computer.jpg", "Viscount C-500 Wireless Bike Computer", 49m, 30 },
                    { 35, 1, "The constant up and down nature of Mana Road. There are actually three trails which make up the loop: Horse Creek-Cattle Creek-Lower Twin Lake. Logs are gone!", "Watch", "~/images/35-Viscount-CardioSport-Sport-Watch.jpg", "Viscount CardioSport Sport Watch", 179m, 12 },
                    { 36, 1, "Third Divide makes up part of the classic Downieville downhill route. There is no preferred direction and the trail is a great connector for several other fun loops.", "Helmet", "~/images/36-Viscount-Microshell-Helmet.jpg", "Viscount Microshell Helmet", 36m, 20 },
                    { 37, 2, "A trail & parking area reconstruction project completed in July 17. Long pedal up form town but best when shuttled to the top.", "Mountain Bike", "~/images/37-Viscount-Mountain-Bikes.jpg", "Viscount Mountain Bike", 635m, 5 },
                    { 38, 1, "One of the best downhills in the area. This ridge is more rugged than the other two ridges. The trail has good flow with some spicy sections.", "Transmitter", "~/images/38-Viscount-Tru-Beat-Heart-Transmitter.jpg", "Viscount Tru-Beat Heart Transmitter", 47m, 20 },
                    { 39, 3, "There are also several sections of slickrock that are fun to ride and allow you to pick your own line. The trails all run parallel to the Fountain Place paved road.", "Cycle Socks", "~/images/39-Wonder-Wood-Cycle-Socks.jpg", "Wonder Wool Cycle Socks", 19m, 30 },
                    { 40, 6, "Built specifically for mountain bikes, a flow trail emphasizes speed and rhythm, featuring berms, rollers, jumps and other features.", "Tires", "~/images/40-X-Pro-All-Weather-Tires.jpg", "X-Pro All Weather Tires", 24m, 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 40);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "ProductDescLong", "ProductDescShort", "ProductImage" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "ProductDescLong", "ProductDescShort", "ProductImage" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "ProductDescLong", "ProductDescShort", "ProductImage" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "ProductDescLong", "ProductDescShort", "ProductImage" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "ProductDescLong", "ProductDescShort", "ProductImage" },
                values: new object[] { "", "", "" });
        }
    }
}
