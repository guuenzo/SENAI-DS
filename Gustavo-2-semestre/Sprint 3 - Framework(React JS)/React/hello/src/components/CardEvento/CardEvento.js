import React from "react";
import "./CardEvento.css";

const CardEvento = ({titulo, texto, textoLink}) => {
    return (<div class="card-evento">
        <h3 class="card-evento__titulo">{titulo}</h3>
        <p class="card-evento__text">{texto}</p>
        <a href="" class="card-evento__conection">{textoLink}</a>
    </div>
    );
}

export default CardEvento;