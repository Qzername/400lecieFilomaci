var map = L.map('map').setView([53.694, 17.5607], 14);

L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
}).addTo(map);

var StaraPlebania = L.marker([53.69514, 17.56398]).addTo(map);
StaraPlebania.bindPopup("<b>Stara plebania</b><br><a href=\"/Person/Stara%20plebania\">Zobacz więcej...</a>").openPopup();

var Starostwo = L.marker([53.69561, 17.55353]).addTo(map);
Starostwo.bindPopup("<b>Starostwo</b><br><a href=\"/Person/Starostwo\">Zobacz więcej...</a>").openPopup();

var AlbinMakowski = L.marker([53.69043, 17.57355]).addTo(map);
AlbinMakowski.bindPopup("<b>Mieszkanie-Muzeum Albina Makowskiego</b><br><a href=\"/Person/Mieszkanie-Muzeum%20Albina%20Makowskiego\">Zobacz więcej...</a>").openPopup();

var StarySzpital = L.marker([53.69424, 17.56531]).addTo(map);
StarySzpital.bindPopup("<b>Stary szpital</b><br><a href=\"/Person/Stary%20szpital\">Zobacz więcej...</a>").openPopup();

var HistoriaSzkoly = L.marker([53.69595, 17.56357]).addTo(map);
HistoriaSzkoly.bindPopup("<b>Historia szkoły</b><br><a href=\"/Person/Historia%20szkoły\">Zobacz więcej...</a>").openPopup();

var LasekMiejski = L.marker([53.7105, 17.5621]).addTo(map);
LasekMiejski.bindPopup("<b>Lasek miejski</b><br><a href=\"/Person/Lasek%20Miejski%20w%20Chojnicach\">Zobacz więcej...</a>").openPopup();

var DolinaSmierci = L.marker([53.7119, 17.5684]).addTo(map);
DolinaSmierci.bindPopup("<b>Dolina Śmierci</b><br><a href=\"/Person/Dolina%20Śmierci\">Zobacz więcej...</a>").openPopup();

var Sad = L.marker([53.69673, 17.55772]).addTo(map);
Sad.bindPopup("<b>Sąd w Chojnicach</b><br><a href=\"/Person/Sąd%20w%20Chojnicach\">Zobacz więcej...</a>").openPopup();

var Jezuici = L.marker([53.69563, 17.56363]).addTo(map);
Jezuici.bindPopup("<b>Jezuici w Chojnicach</b><br><a href=\"/Person/Jezuici%20w%20Chojnicach\">Zobacz więcej...</a>").openPopup();

var Hipolit = L.marker([53.6943, 17.56412]).addTo(map);
Hipolit.bindPopup("<b>Mieszkanie Hipolita Ostoja-Lniskiego</b><br><a href=\"/Person/Mieszkanie%20Hipolita%20Ostoja-Lniskiego\">Zobacz więcej...</a>").openPopup();