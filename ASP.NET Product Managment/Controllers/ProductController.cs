﻿using Microsoft.AspNetCore.Mvc;
using ASP.NET_Product_Managment.Models.Conceretes;

namespace ASP.NET_Product_Managment.Controllers {
    public class ProductController : Controller {

        // Fields

        public List<Product> Products { get; set; }

        // Constructor

        public ProductController() {
            Products = new List<Product>
{
    new Product { Id = 1, Price = 1062, Name = "Soup - Campbells Bean Medley", ImageUrl = "pbladder0@wikia.com" },
    new Product { Id = 2, Price = 398, Name = "Beef - Outside, Round", ImageUrl = "fchestle1@go.com" },
    new Product { Id = 3, Price = 508, Name = "Rambutan", ImageUrl = "hferrarese2@studiopress.com" },
    new Product { Id = 4, Price = 7, Name = "Beer - Camerons Cream Ale", ImageUrl = "ccumpsty3@multiply.com" },
    new Product { Id = 5, Price = 964, Name = "Foil - 4oz Custard Cup", ImageUrl = "tlehr4@ycombinator.com" },
    new Product { Id = 6, Price = 1124, Name = "Sauce - Hoisin", ImageUrl = "cgrissett5@icio.us" },
    new Product { Id = 7, Price = 275, Name = "Juice - Orange 1.89l", ImageUrl = "jbiasetti6@seattletimes.com" },
    new Product { Id = 8, Price = 1135, Name = "Wine - Rubyport", ImageUrl = "troddan7@earthlink.net" },
    new Product { Id = 9, Price = 930, Name = "Foil Wrap", ImageUrl = "zgriffiths8@unc.edu" },
    new Product { Id = 10, Price = 438, Name = "Scallop - St. Jaques", ImageUrl = "mreddan9@google.nl" },
     new Product { Id = 3, Name="Sprite", Price=1, ImageUrl="https://as1.ftcdn.net/v2/jpg/02/86/26/86/1000_F_286268644_FJxZ9RW8bXWWiaZgKajwnwEZ61ynkfOp.jpg"},
                new Product { Id = 4, Name="Doritos",Price=2, ImageUrl="https://as2.ftcdn.net/v2/jpg/04/18/52/25/1000_F_418522520_EMqYNIFkA4V7HlFDjUXBofctOx50NIDR.jpg"},
                new Product { Id = 5,Name="Fanta",Price=1, ImageUrl="https://as1.ftcdn.net/v2/jpg/02/94/38/74/1000_F_294387467_RvmDw6qbKMYVO6CPZlqCaKCDghl8VT0m.jpg"},
               
                new Product { Id = 9,Name="Snickers",Price=3, ImageUrl="https://as2.ftcdn.net/v2/jpg/04/49/89/43/1000_F_449894345_VKGjTTEQAoHcQsR82ro5gZxfeuOjQvko.jpg"},
                new Product { Id = 10,Name="Bounty",Price=2, ImageUrl="https://as1.ftcdn.net/v2/jpg/03/06/42/02/1000_F_306420203_eHsZjFFxuoSyZ8ccUYLKA52NcFbLKiio.jpg"},
               
                new Product { Id = 17,Name="Dynamit",Price=8, ImageUrl="https://as2.ftcdn.net/v2/jpg/04/84/12/69/1000_F_484126929_jvRBY6b7G6F9OcyOFS3RXRyodAysNS2q.jpg"},
                new Product { Id = 18,Name="Twix",Price=2, ImageUrl="https://as2.ftcdn.net/v2/jpg/03/36/44/81/1000_F_336448171_8oHY6yEdZDhUIJDHcpPPnmWmGtwf1v40.jpg"},
    new Product { Id = 11, Price = 270, Name = "Silicone Parch. 16.3x24.3", ImageUrl = "cludwiga@vinaora.com" },
    new Product { Id = 12, Price = 301, Name = "Hog / Sausage Casing - Pork", ImageUrl = "rcrumleyb@smh.com.au" },
    new Product { Id = 13, Price = 296, Name = "Water - Mineral, Carbonated", ImageUrl = "esoreauc@washingtonpost.com" },
    new Product { Id = 14, Price = 1151, Name = "Food Colouring - Green", ImageUrl = "chemmsd@vk.com" },
    new Product { Id = 15, Price = 822, Name = "Southern Comfort", ImageUrl = "agommeye@baidu.com" },
    new Product { Id = 16, Price = 1195, Name = "Water, Tap", ImageUrl = "cshellyf@xinhuanet.com" },
    new Product { Id = 17, Price = 894, Name = "Sultanas", ImageUrl = "mgetheng@google.nl" },
    new Product { Id = 18, Price = 1125, Name = "Wine - Rhine Riesling Wolf Blass", ImageUrl = "rrookh@spiegel.de" },
    new Product { Id = 19, Price = 350, Name = "Lettuce - Mini Greens, Whole", ImageUrl = "cwikeyi@usda.gov" },
    new Product { Id = 20, Price = 345, Name = "Banana - Leaves", ImageUrl = "rlamarj@ehow.com" },
    new Product { Id = 21, Price = 920, Name = "Pancetta", ImageUrl = "rbeddinghamk@miibeian.gov.cn" },
    new Product { Id = 22, Price = 1036, Name = "Duck - Fat", ImageUrl = "jperingl@sina.com.cn" },
    new Product { Id = 23, Price = 838, Name = "Milk - 2%", ImageUrl = "rgrigolim@constantcontact.com" },
    new Product { Id = 24, Price = 598, Name = "Appetizer - Shrimp Puff", ImageUrl = "jocahilln@networkadvertising.org" },
    new Product { Id = 25, Price = 1032, Name = "Napkin White", ImageUrl = "rdanburyo@webmd.com" },
     new Product { Id = 11,Name="Salmon",Price=25, ImageUrl="https://as2.ftcdn.net/v2/jpg/02/12/37/63/1000_F_212376358_hEeAulufAEmVFmTFTQKAuFPH4xKolOUI.jpg"},
                new Product { Id = 12,Name="Cappy",Price=2, ImageUrl="https://as2.ftcdn.net/v2/jpg/04/15/84/73/1000_F_415847356_2QDOokHpCeA4lDpJOB8B8wERpdP5XeoP.jpg"},
                new Product { Id = 13,Name="Red Bull",Price=6, ImageUrl="https://as1.ftcdn.net/v2/jpg/04/21/25/84/1000_F_421258494_e3Pb8EzodyP80xRHQ5aSue504SRwOkbs.jpg"},
                new Product { Id = 14,Name="Hell",Price=5, ImageUrl="https://as2.ftcdn.net/v2/jpg/04/35/91/27/1000_F_435912713_55qeqIUz28nTRYMhvoo9OX9njkSlvp4q.jpg"},
                new Product { Id = 15,Name="Bizon",Price=2, ImageUrl="data:image/jpeg;base64,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"},
                new Product { Id = 16,Name="Burn",Price=5, ImageUrl="https://as2.ftcdn.net/v2/jpg/01/43/52/27/1000_F_143522769_z9LESKOxPzZCBx9Voy7buZIaHU0n8Fjx.jpg"},
    new Product { Id = 26, Price = 92, Name = "Shiratamako - Rice Flour", ImageUrl = "gdancyp@cdbaby.com" },
    new Product { Id = 27, Price = 921, Name = "Cheese - Havarti, Roasted Garlic", ImageUrl = "vstroyanq@canalblog.com" },
    new Product { Id = 28, Price = 136, Name = "Coffee - Frthy Coffee Crisp", ImageUrl = "lshambrookr@timesonline.co.uk" },
    new Product { Id = 29, Price = 586, Name = "Trueblue - Blueberry", ImageUrl = "jknoks@delicious.com" },
    new Product { Id = 30, Price = 17, Name = "Beef - Ox Tongue, Pickled", ImageUrl = "rferrollit@google.pl" },
    new Product { Id = 31, Price = 1102, Name = "Mushroom - Morel Frozen", ImageUrl = "jberku@shinystat.com" },
    new Product { Id = 32, Price = 1105, Name = "Beef - Roasted, Cooked", ImageUrl = "dmorforthv@cargocollective.com" },
     new Product { Id = 6,Name="Mirinda",Price=2, ImageUrl="https://as2.ftcdn.net/v2/jpg/05/05/79/99/1000_F_505799961_IfByycPLuAWGIT1DNoK4jC0BnKyPu0Fx.jpg"},
                new Product { Id = 7,Name="Mountain Dew",Price=2, ImageUrl="https://as1.ftcdn.net/v2/jpg/04/37/90/26/1000_F_437902620_Wj5AhdQtSh4cJTC1R2EC4W7cPhndnWJ9.jpg"},
                new Product { Id = 8,Name="Pepsi",Price=1, ImageUrl="https://as1.ftcdn.net/v2/jpg/03/23/86/24/1000_F_323862457_5RaEzJNg6yeYx6RjbU4WwkAl3R0yxNQt.jpg"},
    new Product { Id = 33, Price = 1062, Name = "Shrimp - 100 / 200 Cold Water", ImageUrl = "ikallw@cam.ac.uk" },
    new Product { Id = 34, Price = 799, Name = "Beef - Sushi Flat Iron Steak", ImageUrl = "csamplex@about.me" },
    new Product { Id = 35, Price = 399, Name = "Chicken - Whole", ImageUrl = "dcowany@yolasite.com" },
    new Product { Id = 36, Price = 462, Name = "Butter - Pod", ImageUrl = "ajorgerz@deviantart.com" },
    new Product { Id = 37, Price = 816, Name = "Salt - Seasoned", ImageUrl = "cbaselio10@dagondesign.com" },
    new Product { Id = 38, Price = 949, Name = "Blackberries", ImageUrl = "jbirtley11@feedburner.com" },
    new Product { Id = 39, Price = 1140, Name = "Poppy Seed", ImageUrl = "jemby12@unc.edu" },
    new Product { Id = 40, Price = 248, Name = "Squid U5 - Thailand", ImageUrl = "wbundy13@ovh.net" }
};

        }


        // Actions

        public IActionResult AllProducts() {
            return View(Products);
        }

        public IActionResult ProductById(int id) {
            Product product= null;
            foreach (var item in Products)
                if (item.Id == id) product = item;

            return View(product);
        }
    }
}
