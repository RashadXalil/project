const nameInput = document.getElementById("nameInput");
const surnameInput = document.getElementById('surnameInput');
const ageInput = document.getElementById('ageInput');
const expreinceInput = document.getElementById('expreinceInput');
const selectNational = document.getElementById('Nationality');
const selectPosition = document.getElementById('Position');
const myButton = document.getElementById('my_button');
const liste = document.getElementById('table');
const tbody = document.getElementById('tbodyID');

myButton.onclick=function(){
    if(nameInput.value=="", surnameInput.value=="", ageInput.value=="", expreinceInput.value=="")
    {

    }
    else{
    const deleteElement = document.createElement("button");
    deleteElement.innerHTML = "delete";
   
    let tName = document.createElement('td');
    let tSurname = document.createElement('td')
    let tAge = document.createElement('td');
    let tEpreince = document.createElement('td');
    let tNational = document.createElement('td');
    let tPosition = document.createElement('td');    

    tName.textContent = nameInput.value;
    tSurname.textContent=surnameInput.value;
    tAge.textContent=ageInput.value;
    tEpreince.textContent=expreinceInput.value;
    tNational.innerHTML= selectNational.value;
    tPosition.innerHTML = selectPosition.value;
  

    let tr = document.createElement('tr');

    tr.appendChild(tName);
    tr.appendChild(tSurname);
    tr.appendChild(tAge);
    tr.appendChild(tEpreince);
    tr.appendChild(tNational);
    tr.appendChild(tPosition);
    tr.appendChild(deleteElement);   

    tbody.appendChild(tr);

    deleteElement.addEventListener('click', function () {
        tr.remove();
    })
    
    nameInput.value="";
    surnameInput.value="";
    ageInput.value="";
    expreinceInput.value="";
  

    nameInput.focus();
}
}

