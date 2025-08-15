function changeColor(){
    p1.style.color = 'red';
}

titulo.addEventListener('click', changeColor);

function addParagraph(){
    const paragraphToBeAdd = document.createElement("p");
    const paragraphToBeAddText = document.createTextNode("Texto para o Paragráfo adicionado.");

    paragraphToBeAdd.appendChild(paragraphToBeAddText);

    document.body.appendChild(paragraphToBeAdd);

}
buttonAddParagraph.addEventListener('click', addParagraph);

function searchAPI(){
    const users_url = "https://jsonplaceholder.typicode.com/users";

    // Requisição HTTP GET {request -> SERVER -> response}
    fetch(users_url)
        .then(reponse => {
            
        }
        )
}
