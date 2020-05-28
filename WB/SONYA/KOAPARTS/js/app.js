// Для удобного доступа забираем элементы со страницы в переменные
const catItem = document.querySelectorAll(".entry"); //Массив элементов найденных по запросу товароы
const checkOffer = document.querySelector(".checkOfferButton");
const cartButton = document.querySelector(".cartIcon");
const feedBackButton = document.querySelector(".feedBackIcon");
const photoGalleryButton = document.querySelector(".photoGallery");
const mapButton = document.querySelector(".mapLogo");
const fnService = document.querySelector("#fnService");
const viService = document.querySelector("#viService");
const vrService = document.querySelector("#vrService");

//SWAL.FIRE - функция вызова окошка из документации sweetlert

//Добавление слушателя на иконку обратной связи
feedBackButton.addEventListener("click", () => {
  Swal.mixin({
    input: "text",
    confirmButtonText: "Next &rarr;",
    confirmButtonColor: "#787878",
    background: "rgb(227, 227, 227)",
    backdrop: "#000000cf",
    progressSteps: ["1", "2", "3"],
  })
    .queue([
      {
        title: "YOUR CONTACT",
        text: "type your contact phone/email",
      },
      {
        title: "YOUR COMPANY",
        text: "type your company name (if exist)",
      },
      {
        title: "MESSAGE",
        text: "type your message",
      },
    ])
    .then((result) => {
      if (!result.dismiss) {
        const Toast = Swal.mixin({
          toast: true,
          background: "rgb(227, 227, 227)",
          position: "bottom-end",
          showConfirmButton: false,
          timer: 6000,
          timerProgressBar: true,
        });
        Toast.fire({
          icon: "success",
          title: "Thank you! Your feedback have been successfully sent!",
        });
      }
    });
});

// Добавление слушателя на нажатие для иконки фотогалереи
photoGalleryButton.addEventListener("click", () => {
  Spotlight.show(
    [
      {
        title: "Hello",
        description: "World",
        src:
          "https://sun9-72.userapi.com/c857216/v857216167/14cf0d/1JKsIjgGSGQ.jpg",
      },

      {
        title: "Hello",
        description: "World",
        src:
          "https://sun9-72.userapi.com/c857216/v857216167/14cf0d/1JKsIjgGSGQ.jpg",
      },
      {
        title: "Hello",
        description: "World",
        src:
          "https://sun9-72.userapi.com/c857216/v857216167/14cf0d/1JKsIjgGSGQ.jpg",
      },
      {
        title: "Hello",
        description: "World",
        src:
          "https://sun9-72.userapi.com/c857216/v857216167/14cf0d/1JKsIjgGSGQ.jpg",
      },
      {
        title: "Hello",
        description: "World",
        src:
          "https://sun9-72.userapi.com/c857216/v857216167/14cf0d/1JKsIjgGSGQ.jpg",
      },
    ],
    {
      theme: "white",
      autohide: false,
      control: ["autofit", "zoom"],
    }
  );
});

//Слушатель нажатия на иконку карты
mapButton.addEventListener("click", () => {
  //Инициализация яндекс-карт
  ymaps.ready(function () {
    var ymapMap = new ymaps.Map("ymapMap", {
      center: [55.753994, 37.622093],
      zoom: 17,
      controls: ["routePanelControl"],
    });
    //Опции: тип общественный транспорт, адрес
    var control = ymapMap.controls.get("routePanelControl");
    control.routePanel.state.set({
      type: "masstransit",
      fromEnabled: true,
      toEnabled: false,
      to: "Нежинская улица д. 7",
    });
    //опции: поворот маршрута + типы: общественный транспорт, пеший ход, такси
    control.routePanel.options.set({
      reverseGeocoding: true,
      types: { masstransit: true, pedestrian: true, taxi: true },
    });
  });

  //инициализация модального окна с картой в теле
  Swal.fire({
    title: "",
    text: "cmon",
    html: `
        <div id="ymapMap" style="min-width: 100%; min-height: 600px"></div>
            `,
    // confirmButtonText: "$1500",
    confirmButtonColor: "#787878",
    background: "rgb(227, 227, 227)",
    backdrop: "#FFFFFF2E",
  });
});

//Добавление слушателя для нажатий на кнопки заказа услуг с вызовом модального окна
fnService.addEventListener("click", () => {
  Swal.mixin({
    input: "text",
    confirmButtonText: "Next &rarr;",
    confirmButtonColor: "#787878",
    background: "rgb(227, 227, 227)",
    backdrop: "#000000cf",
    progressSteps: ["1", "2", "3"],
  })
    .queue([
      {
        title: "CAR INFO",
        text: "type your vehicle info (vin)",
      },
      {
        title: "SPARES INFO",
        text: "type what you need for your vehicle",
      },
      {
        title: "PAYMENT",
        text: "type card/cash",
      },
    ])
    .then((result) => {
      if (!result.dismiss) {
        //Вызов ярлычка об успешном процессе оформления заказа
        const Toast = Swal.mixin({
          toast: true,
          background: "rgb(227, 227, 227)",
          position: "bottom-end",
          showConfirmButton: false,
          timer: 6000,
          timerProgressBar: true,
        });
        Toast.fire({
          icon: "success",
          title: "Thank you, we are processing your order!",
        });
      }
    });
});

viService.addEventListener("click", () => {
  Swal.mixin({
    input: "text",
    confirmButtonText: "Next &rarr;",
    confirmButtonColor: "#787878",
    background: "rgb(227, 227, 227)",
    backdrop: "#000000cf",
    progressSteps: ["1", "2", "3"],
  })
    .queue([
      {
        title: "CAR INFO",
        text: "type your vehicle info (vin)",
      },
      {
        title: "SPARES INFO",
        text: "type the inspection kind",
      },
      {
        title: "PAYMENT",
        text: "type card/cash",
      },
    ])
    .then((result) => {
      if (!result.dismiss) {
        //Вызов ярлычка об успешном процессе оформления заказа
        const Toast = Swal.mixin({
          toast: true,
          background: "rgb(227, 227, 227)",
          position: "bottom-end",
          showConfirmButton: false,
          timer: 6000,
          timerProgressBar: true,
        });
        Toast.fire({
          icon: "success",
          title: "Thank you, we are processing your order!",
        });
      }
    });
});

vrService.addEventListener("click", () => {
  Swal.mixin({
    input: "text",
    confirmButtonText: "Next &rarr;",
    confirmButtonColor: "#787878",
    background: "rgb(227, 227, 227)",
    backdrop: "#000000cf",
    progressSteps: ["1", "2", "3"],
  })
    .queue([
      {
        title: "CAR INFO",
        text: "type your vehicle info (vin)",
      },
      {
        title: "SPARES INFO",
        text: "type where is your vehicle not okay",
      },
      {
        title: "PAYMENT",
        text: "type card/cash",
      },
    ])
    .then((result) => {
      if (!result.dismiss) {
        //Вызов ярлычка об успешном процессе оформления заказа
        const Toast = Swal.mixin({
          toast: true,
          background: "rgb(227, 227, 227)",
          position: "bottom-end",
          showConfirmButton: false,
          timer: 6000,
          timerProgressBar: true,
        });
        Toast.fire({
          icon: "success",
          title: "Thank you, we are processing your order!",
        });
      }
    });
});

//Обработка КАЖДОГО из найденных товаров
catItem.forEach((actualItem) => {
  actualItem.addEventListener("mouseenter", (e) => {
    e.target.firstElementChild.style.opacity = "1";
  }); //слушатель для наведения (появление элемента с описанием)
  actualItem.addEventListener("mouseleave", (e) => {
    e.target.firstElementChild.style.opacity = "0";
  }); //слушатель для наведения (появление элемента с описанием)
  actualItem.addEventListener("click", (e) => {
    //Вызов окна  с подробным описанием товара и ПОКУПКОЙ В ОДИН КЛИК
    Swal.fire({
      title: "CONTINENTAL SPORTCONTACT",
      text: "22 inch wheel",
      html: `
              <p>
              Black Chili for maximum grip in all directions enables supreme driving experience
              Vectoring for maximum control, a new era in tread pattern development
              Aralon350™, the new adaptive hybrid cap ply for maximum stability at high speed up to 350km/h
              </p>
              `,
      imageUrl: "/assets/img/wheel.png",
      confirmButtonText: "$1500",
      confirmButtonColor: "#787878",
      background: "rgb(227, 227, 227)",
      backdrop: "#FFFFFF2E",
    }).then((result) => {
      if (!result.dismiss) {
        //Вызов окна с уточнением данных заказчика
        Swal.mixin({
          input: "text",
          confirmButtonText: "Next &rarr;",
          confirmButtonColor: "#787878",
          background: "rgb(227, 227, 227)",
          backdrop: "#FFFFFF2E",
          progressSteps: ["1", "2", "3"],
        })
          .queue([
            {
              title: "ORDER INFORMATION",
              text: "type your contacts",
            },
            {
              title: "DELIVERY",
              text: "type your both lines of delivery address",
            },
            {
              title: "PAYMENT",
              text: "type card/cash",
            },
          ])
          .then((result) => {
            if (result.value) {
              //Вызов окна о успешном оформлении заказа
              Swal.fire({
                title: "YEAH!",
                text: "We are started to work on your order",
                confirmButtonColor: "#787878",
                background: "rgb(227, 227, 227)",
                backdrop: "#FFFFFF2E",
                confirmButtonText: ":)",
              }).then(() => {
                //Вызов ярлычка об успешном процессе оформления заказа
                const Toast = Swal.mixin({
                  toast: true,
                  background: "rgb(227, 227, 227)",
                  position: "bottom-end",
                  showConfirmButton: false,
                  timer: 6000,
                  timerProgressBar: true,
                });
                Toast.fire({
                  icon: "success",
                  title: "Thank you, we are processing your order!",
                });
              });
            }
          });
      }
    });
  });
});

//Добавление слушателя события клика на кнопку акции в ленте новостей
checkOffer.addEventListener("click", () => {
  Swal.fire({
    title: "ERROR!",
    text: `Offer is no longer available, we are so sorry!`,
    icon: "error",
    confirmButtonText: ":(",
    background: "rgb(227, 227, 227)",
    backdrop: "#FFFFFF2E",
  });
});

//Добавление слушателя события клика на кнопку корзины
cartButton.addEventListener("click", () => {
  Swal.fire({
    title: "Whoops!",
    text: "your cart is empty, add something to move on! ;)",
    confirmButtonText: "meh",
    confirmButtonColor: "#787878",
    background: "rgb(227, 227, 227)",
    backdrop: "#FFFFFF2E",
  });
});

//Инициализация библиотеки с промоткой
new fullpage("#fullpage", {
  menu: "#menu", //задание идентификатора меню в опции из документации
  anchors: [
    "homePage",
    "nwPage",
    "cpPage",
    "cpPage",
    "cpPage",
    "caPage",
    "svPage",
    "contactsPage",
  ], //идентификаторы названий страниц для ссылок на элементы разметки
  scrollingSpeed: 600, //скорость
  scrollHorizontally: true,
});
