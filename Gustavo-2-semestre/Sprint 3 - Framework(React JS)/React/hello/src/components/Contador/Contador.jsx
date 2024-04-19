import React, { useState } from "react";
import './Contador.css'

const Contador = () => {
    //state(leitura), funcao manipuladora do state 
    const [contador, setContador] = useState(0); //valor inicial da variavel

    function handleIncrementar() {
        setContador(contador + 1);
    }

    function handleDecrementar() {
        contador > 0 ? setContador(contador - 1) : alert("Não pode conter números negativos")
    }

    return (
        <>
            <p>{contador}</p>
            <button onClick={handleDecrementar}>Decrementar</button>
            <button onClick={handleIncrementar}>Incrementar</button>
        </>

    );
}

export default Contador;