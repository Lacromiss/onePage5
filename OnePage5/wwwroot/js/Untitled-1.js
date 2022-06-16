const headerElm = document.getElementById("header");
const btnNavig = document.getElementById("btn-navig");

btnNavig.addEventListener("click", function () {
  headerElm.classList.toggle("optimize");
});
