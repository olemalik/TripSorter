const MESSAGE_FINAL_DESTINATION = "You have arrived at your final destination.";
$(document).ready(function () {
    $('.carousel').carousel('pause');
   
    getTransportation();
});

function carouselConfig() {
    let items = document.querySelectorAll('.carousel .carousel-item')

    items.forEach((el) => {
        const minPerSlide = 3
        let next = el.nextElementSibling
        for (var i = 1; i < minPerSlide; i++) {
            if (!next) {
                // wrap carousel by using first child
                next = items[0]
            }
            let cloneChild = next.cloneNode(true)
            el.appendChild(cloneChild.children[0])
            next = next.nextElementSibling
        }
    })
}

async function getTransportation(){
    debugger

    var result = await getApiAjaxCall("transport");
    loadCarousel(result);
//alert(JSON.stringify(result));
  
}

function loadCarousel(boardingCards) {
    var strhtml = "";
    var i = 1;
    var carouselActive = "active";
    var imageUrl = "";
    boardingCards.push({ message: MESSAGE_FINAL_DESTINATION });
    boardingCards.forEach((item) => {
        debugger
        if (i != 1) {
            carouselActive = "";
        }
        if (i % 2 === 0) {
            imageUrl = `//via.placeholder.com/500x400?text=${i}`;
        } else {
            imageUrl = `//via.placeholder.com/500x400/aba?text=${i}`;
        }
        //<p class="font-weight-bold text-justify">${item.message}</p>
        //<h5>${item.message}</h5>

        strhtml += `  <div class="carousel-item ${carouselActive}">
                        <div class="col-md-4">
                            <div class="card">
                                <div class="card-img">
                                    <img src="${imageUrl}" class="img-fluid">
                                </div>
                                <div class="card-img-overlay">
                                    <p class="text-center fs-6 fw-bold">${item.message}</p>
                                </div>
                            </div>
                        </div>
                    </div>`;

        i++;

    });

    $("#boarding-card").append(strhtml);
    carouselConfig();
}


