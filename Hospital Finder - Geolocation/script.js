function withPosition(position) {
    getHospitals(position, function (hospitals) {
        for (var i = 0; i < hospitals.length; i++) {
            var hospital = hospitals[i];
            markHospital(hospital);
        }
    });
}

function markHospital(hospital) {
  var location = hospital.geometry.location;
  var marker = new google.maps.Marker({
    map: map,
    position: location
  });

  google.maps.event.addListener(marker, 'click', function() {
    infowindow.setContent(hospital.name);
    infowindow.open(map, this);
  });
}

function getHospitals(position, withHospitals) {
    var location = {lat: position.coords.latitude, lng: position.coords.longitude};
    var mapHolder = document.getElementById('map');
    map = new google.maps.Map (mapHolder, {
       center : location,
       zoom : 15
    });
    
    infowindow = new google.maps.InfoWindow();

    var service = new google.maps.places.PlacesService(map);
    service.nearbySearch({
        location: location,
        radius: 500,
        types: ['hospital']
    }, withHospitals);
    
}

function withError(error) {
    
}

var map;
var infowindow;

function initialize() {
    if (navigator.geolocation)
        navigator.geolocation.getCurrentPosition(withPosition, withError);
}