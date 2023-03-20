var map = L.map('map').setView([53.694, 17.5607], 14);

L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
}).addTo(map);

var StaraPlebania = L.marker([53.69514, 17.56398]).addTo(map);
StaraPlebania.bindPopup("<b>Stara plebania</b><br><a href=\"/400lecie/Person/Stara%20plebania.html\">Zobacz więcej...</a>");

var Starostwo = L.marker([53.69561, 17.55353]).addTo(map);
Starostwo.bindPopup("<b>Starostwo</b><br><a href=\"/400lecie/Person/Starostwo.html\">Zobacz więcej...</a><br><a href=\"/400lecie/Person/Stanisław%20Sikorski.html\">Powiązane ze Stanisławem Sikorskim...</a>");

var AlbinMakowski = L.marker([53.69043, 17.57355]).addTo(map);
AlbinMakowski.bindPopup("<b>Mieszkanie-Muzeum Albina Makowskiego</b><br><a href=\"/400lecie/Person/Mieszkanie-Muzeum%20Albina%20Makowskiego.html\">Zobacz więcej...</a>");

var StarySzpital = L.marker([53.69424, 17.56531]).addTo(map);
StarySzpital.bindPopup("<b>Stary szpital</b><br><a href=\"/400lecie/Person/Stary%20szpital.html\">Zobacz więcej...</a>");

var HistoriaSzkoly = L.marker([53.69595, 17.56357]).addTo(map);
HistoriaSzkoly.bindPopup("<b>Historia szkoły</b><br><a href=\"/400lecie/Person/Historia%20szkoły.html\">Zobacz więcej...</a>");

var LasekMiejski = L.marker([53.7086, 17.5596]).addTo(map);
LasekMiejski.bindPopup("<b>Lasek miejski</b><br><a href=\"/400lecie/Person/Lasek%20Miejski%20w%20Chojnicach.html\">Zobacz więcej...</a>");

var DolinaSmierci = L.marker([53.7119, 17.5684]).addTo(map);
DolinaSmierci.bindPopup("<b>Dolina Śmierci</b><br><a href=\"/400lecie/Person/Dolina%20Śmierci.html\">Zobacz więcej...</a>");

var Sad = L.marker([53.69673, 17.55772]).addTo(map);
Sad.bindPopup("<b>Sąd w Chojnicach</b><br><a href=\"/Person/Sąd%20w%20Chojnicach.html\">Zobacz więcej...</a><br><a href=\"/400lecie/Person/Jan%20Karnowski.html\">Powiązane z Janem Karnowskim...</a>");

var Jezuici = L.marker([53.69563, 17.56363]).addTo(map);
Jezuici.bindPopup("<b>Jezuici w Chojnicach</b><br><a href=\"/400lecie/Person/Jezuici%20w%20Chojnicach.html\">Zobacz więcej...</a>");

var Hipolit = L.marker([53.6943, 17.56412]).addTo(map);
Hipolit.bindPopup("<b>Mieszkanie Hipolita Ostoja-Lniskiego</b><br><a href=\"/400lecie/Person/Mieszkanie%20Hipolita%20Ostoja-Lniskiego.html\">Zobacz więcej...</a>");

var Hoffman = L.marker([53.69468, 17.55151]).addTo(map);
Hoffman.bindPopup("<b>Mieszkanie Heleny i Bogumiła Hoffmann</b><br><a href=\"/400lecie/Person/Helena%20Hoffmann.html\">Zobacz więcej o Helenie Hoffmann...</a><br><a href=\"/400lecie/Person/Bogumił%20Hoffmann.html\">Zobacz więcej o Bogumile Hoffmann...</a>");

var Lukowicz = L.marker([53.69105, 17.57024]).addTo(map);
Lukowicz.bindPopup("<b>Mieszkanie Jana Pawła i Jana Karola Łukowicz</b><br><a href=\"/400lecie/Person/Jan%20Paweł%20Łukowicz.html\">Zobacz więcej o Janie Pawle Łukowiczu...</a><br><a href=\"/400lecie/Person/Jan%20Karol%20Łukowicz.html\">Zobacz więcej o Janie Karolu Łukowiczu...</a>");

var Bieszkowie = L.marker([53.68958, 17.57432]).addTo(map);
Bieszkowie.bindPopup("<b>Mieszkanie Bieszków</b><br><a href=\"/400lecie/Person/Stefan%20Bieszk.html\">Zobacz więcej...</a>");

var Ceynowy = L.marker([53.7048, 17.5673]).addTo(map);
Ceynowy.bindPopup("<b>Pomnik Floriana Ceynowy</b><br><a href=\"/400lecie/Person/Florian%20Ceynowa.html\">Zobacz więcej...</a>");

var Wagner = L.marker([53.69705, 17.56038]).addTo(map);
Wagner.bindPopup("<b>Mieszkanie Leona Wagnera</b><br><a href=\"/400lecie/Person/Leon%20Wagner.html\">Zobacz więcej...</a>");

var Aula = L.marker([53.69564, 17.56397]).addTo(map);
Aula.bindPopup("<b>Aula</b><br><a href=\"/400lecie/Person/Aula.html\">Zobacz więcej...</a>");

var Wolszlegier = L.marker([53.69702, 17.56996]).addTo(map);
Wolszlegier.bindPopup("<b>Grób ks. Antoniego Wolszlegiera</b><br><a href=\"/400lecie/Person/Antoni%20Wolszlegier.html\">Zobacz więcej...</a>");