import React, { Component } from 'react';
import '../../global.css';
import './Advisor.css';
import '../../assets/css/icons/css/all.css'
import '../../assets/css/style.css'

class Advisor extends Component {
    render() {
        return (
            <div class="container" style={{ paddingTop: 100, paddingBottom: 100, textAlign: "left" }}>
                <h4>Financial Advisor</h4>
                <div class="row" style={{ textAlign: "left" }}>
                    <div class="col-12 mb-4">
                        <div class="box shadow">
                            <div class="border-top-styled"></div>
                            <div class="perfil-box p-3 d-flex">
                                <div id="info-perfil" class="col-6 p-0">
                                    <h4>Informa&#231;&#245;es gerais</h4>
                                    <div class="d-flex">
                                        <img id="perfil-img" src={require('../../assets/img/Ellipse.jpg')} class="circle-rounded" />
                                        <div class="perfil-info d-flex flex-column">
                                            <span class="px-2 mb-2">Ben&#237;cio Anthony Vieira - MetaStox Investimentos</span>
                                            <span><i class="fas fa-envelope px-2"></i>anthonybenicio@gmail.com</span>
                                            <span><i class="fas fa-briefcase px-2"></i>Confira o curr&#237;culo de Ben&#237;cio aqui</span>
                                            <div class="zap-button p-1 mt-2">
                                                <span class="px-2 mb-2">Mande uma mensagem por whatsapp</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-3">
                                    <h4>Produtos</h4>
                                    <ul class="list-unstyled">
                                        <li>A&#231;&#245;es
                                        </li>
                                        <li>Op&#231;&#245;es
                                        </li>
                                        <li>Fundo imobili&#225;rio
                                        </li>
                                        <li>Fundo de a&#231;&#245;es</li>
                                        <li>T&#237;tulos p&#250;blicos</li>
                                    </ul>
                                </div>
                                <div class="col-3">
                                    <h4>Especialidades</h4>
                                    <ul class="list-unstyled">
                                        <li>Setor imobili&#225;rio de B&#250;zios</li>
                                        <li>Pre&#231;o da arroba do boi gordo</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row d-flex" >
                    <div class="col-3">
                        <div id="numero-clientes" class="box shadow">
                            <div class="border-top-styled"></div>
                            <h4 class="p-3 m-0">N&#250;meros de clientes</h4>
                            <p class="text-center">62</p>
                        </div>
                    </div>
                    <div class="col-4">
                        <div id="investimentos" class="box shadow">
                            <div class="border-top-styled"></div>
                            <div class="d-flex flex-column text-center">
                                <h4 class="p-3 m-0">Investimentos</h4>
                                <h6>Patrim&#244;nio total gerido</h6>
                                <span class="">R$ 21 mi</span>
                                <h6>Rentabilidade do &#250;ltimo ano</h6>
                                <span>7,42%</span>
                            </div>
                        </div>
                    </div>
                    <div class="col-5">
                        <div id="depoimentos" class="box shadow text-center">
                            <div class="border-top-styled"></div>
                            <h4 class="p-3 m-0">Depoimentos</h4>
                            <p class="px-3">Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                            Ipsum enim vitae cursus suspendisse. Morbi risus volutpat nibh ultrices quis.
                            Pellentesque pulvinar duis congue non egestas aliquet facilisis. Sagittis quam
                    pharetra purus fames et sit rhoncus, pharetra.</p>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default Advisor; 