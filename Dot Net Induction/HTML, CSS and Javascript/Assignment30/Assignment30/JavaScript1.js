function option3_check(divOption1,divOption2,divOption4) {
    var option1 = document.getElementById("option1");
    option1.checked = false;
    divOption1.style.backgroundColor = "#FFFAFA";
    var option2 = document.getElementById("option2");
    option2.checked = false;
    divOption2.style.backgroundColor = "#FFFAFA";

   var option4 = document.getElementById("option4");
   option4.checked = false;
   divOption4.style.backgroundColor = "#FFFAFA";



}
function option3_uncheck(divOption3) {
    document.getElementById("option3").checked = false;
    divOption3.style.backgroundColor = "#FFFAFA";

}
function changeColor(element) {
   
    if (element.style.backgroundColor === "rgb(135, 206, 235)") {
        element.style.backgroundColor = "#FFFAFA";

    }
    else {
        element.style.backgroundColor = "rgb(135, 206, 235)";

    }
}
