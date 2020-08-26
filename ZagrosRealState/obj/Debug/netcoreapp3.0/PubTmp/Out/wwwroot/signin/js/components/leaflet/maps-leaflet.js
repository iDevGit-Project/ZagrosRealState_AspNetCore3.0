(function ($) {

    'use strict';
	
    // ------------------------------------------------------- //
    // Basic Map tehran
    // ------------------------------------------------------ //	
	var mymap = L.map('basic-map').setView([35.7006177, 51.4013785], 10);

		L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
			maxZoom: 18,
			attribution: '&copy; <a href="http://openstreetmap.org">OpenStreetMap</a> contributors',
			id: 'mapbox.streets'
		}).addTo(mymap);
		
    // ------------------------------------------------------- //
    // Map Marker 32.602, 54.426  32.621, 55.151
    // ------------------------------------------------------ //
	var mymap = L.map('map-marker').setView([32.602, 54.426], 5);

	L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
		maxZoom: 18,
		attribution: '&copy; <a href="http://openstreetmap.org">OpenStreetMap</a> contributors',
		id: 'mapbox.streets'
	}).addTo(mymap);

	L.marker([32.621, 55.151]).addTo(mymap)
		.bindPopup("<b>سلام دنیا!</b><br />من نقشه ایرانم.").openPopup();


	var popup = L.popup();

	function onMapClick(e) {
		popup
			.setLatLng(e.latlng)
			.setContent("You clicked the map at " + e.latlng.toString())
			.openOn(mymap);
	}

	mymap.on('click', onMapClick);
	
    // ------------------------------------------------------- //
    // Custom Marker 32.6575, 51.6776
    // ------------------------------------------------------ //
	var map = L.map('custom-marker').setView([32.65755, 51.6776], 12);

	L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
		attribution: '&copy; <a href="http://openstreetmap.org">OpenStreetMap</a> contributors'
	}).addTo(map);

	var LeafIcon = L.Icon.extend({
		options: {
			shadowUrl: 'assets/img/plugins/leaflet/custom-marker-shadow.png',
			iconSize:     [46, 60],
			shadowSize:   [45, 22],
			iconAnchor:   [22, 94],
			shadowAnchor: [4, 62],
			popupAnchor:  [-3, -76]
		}
	});

	var greenIcon = new LeafIcon({iconUrl: 'assets/img/plugins/leaflet/custom-marker.png'});

	L.marker([51.5, -0.09], {icon: greenIcon}).addTo(map);
	
    // ------------------------------------------------------- //
    // Layers COntrol 32.602, 54.426
	//33.119, 52.405
	//35.729, 51.812
	//27.157, 51.702
    // ------------------------------------------------------ //
	var cities = L.layerGroup();

	L.marker([32.602, 54.426]).bindPopup('اینجا ایران است, مرکز').addTo(cities),
	L.marker([33.119, 52.405]).bindPopup('اصفهان, ایران.').addTo(cities),
	L.marker([35.729, 51.812]).bindPopup('تهران, پایتخت.').addTo(cities),
	L.marker([27.157, 51.702]).bindPopup('خلیج فارس, ایران.').addTo(cities);


	var mbAttr = '&copy; <a href="http://openstreetmap.org">OpenStreetMap</a> contributors',
		mbUrl = 'https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoibWFwYm94IiwiYSI6ImNpejY4NXVycTA2emYycXBndHRqcmZ3N3gifQ.rJcFIG214AriISLbB6B5aw';

	var grayscale   = L.tileLayer(mbUrl, {id: 'mapbox.light', attribution: mbAttr}),
		streets  = L.tileLayer(mbUrl, {id: 'mapbox.streets',   attribution: mbAttr});

	var map = L.map('layer-control', {
		center: [32.602, 54.426],
		zoom: 5,
		layers: [grayscale, cities]
	});

	var baseLayers = {
		"سیاه و سفید": grayscale,
		"خیابان ها": streets
	};

	var overlays = {
		"شهرها": cities
	};

	L.control.layers(baseLayers, overlays).addTo(map);
	
})(jQuery);