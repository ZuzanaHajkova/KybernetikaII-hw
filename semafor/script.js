async function My() {
    function sleep(ms) {
      return new Promise(resolve => setTimeout(resolve, ms));
    }
  
    const lights = ["cervena", "zluta", "zelena"];//uloží proměnné
  
    while (true) { //cyklus se bude opakovat do nekonečna
      for (i = 0; i < lights.length; i++) {
        
        lights.forEach(id => {
          document.getElementById(id).style.opacity = "0";
        }); //vypne všechny barvy na začátek
  
        document.getElementById(lights[i]).style.opacity = "1"; //postupně rozsvicuje každou barvu
        await sleep(2000); //počká 2 sekundy
      }
    }
  }
  
  My();