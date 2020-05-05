import React from 'react';
import './advisors.css';

const Advisors = ({ advisors }) => {
    return (
        <div style={{ textAlign: "left" }}>
            {advisors.map((advisor) => (
                <a href= "/advisor/{advisor.Id}">
                <li class="item d-flex p-3 justify-content-between mb-3">
                        <img src={require('../assets/img/Ellipse.jpg')} class="rounded-circle" />
                        <div class="nome col-md-2">
                            <span class="d-block" ><strong>Nome</strong></span>
                            <span >{advisor.name}</span>
                    </div>
                    <div class="patrimonio col-md-2">
                        <span class="d-block"><strong>Patrim&#244;nio gerido</strong></span>
                        <span>R$ {advisor.heritageAmount}</span>
                    </div>
                    <div class="produtos col-md-4">
                        <span class="d-block"><strong>Principais produtos</strong></span>
                            <span>CRI/CRA - A&#231;&#245;es - T&#237;tulos p&#250;blicos - Criptomoeda</span>
                    </div>
                    <div class="clientes pr-2 col-md-3">
                        <span class="d-block"><strong>N&#250;meros de clientes</strong></span>
                        <span>{advisor.clientAmount}</span>
                    </div>
                    </li>
                    </a>
            ))}
            </div>
    )
};

export default Advisors