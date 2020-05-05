import React, { Component } from 'react';
import '../../global.css';
import './cadastrocliente.css';
import '../../assets/css/icons/css/all.css'
import '../../assets/css/style.css'


class CadastroCliente extends Component {

    render() {
        return (
            <div class="d-flex p-0 m-0" style={{ textAlign : "left" }}>
                <div class="col-6 p-0" id = "esquerdo">
                </div>
                <div id="direito" class="col-6 p-5">
                    <h4>Cadastro de cliente</h4>
                    <p class="mb-4">Insira seus dados abaixo</p>
                    <form action = "/advisorList">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Nome</label>
                            <input type="text" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Insira seu Nome"/>
                </div>
                            <div class="form-group row">
                                <div class="col-8">
                                    <label for="exampleInputEmail1">Email</label>
                                    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Digite seu email"/>
                    </div>
                                    <div class="col-4">
                                        <label for="exampleInputEmail1">Telefone</label>
                                        <input type="text" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Digite seu Telefone"/>
                    </div>
                                    </div>
                                    <div class="form-group row">
                                        <div class="col-6">
                                            <label for="exampleInputEmail1">Senha</label>
                                            <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Digite sua Senha"/>
                    </div>
                                            <div class="col-6">
                                <label for="exampleInputEmail1">Confirma&#231;&#227;o de senha</label>
                                                <input type="text" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Confirme sua Senha"/>
                    </div>
                                            </div>
                                            <div class="form-group">
                            <label for="exampleInputEmail1">Patrim&#244;nio</label>
                                                <input type="text" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Digite seu Patrimonio"/>
                </div>
                                                <div class="form-group row">
                                                    <div class="col-8">
                                                        <label for="exampleInputEmail1">Horizonte de investimento</label>
                                                        <select id="inputState" class="form-control">
                                                            <option>curto prazo (1 a 2 anos)</option>
                                    <option>m&#233;dio prazo (3 a 5 anos)
</option>
                                                            <option>longo prazo (mais de 5 anos)</option>
                                                        </select>
                                                    </div>
                                                    <div class="col-4">
                                                        <label for="exampleInputEmail1">Perfil de risco</label>
                                                        <select id="inputState" class="form-control">
                                                            <option>Arrojado</option>
                                                            <option>Moderado</option>
                                                            <option>Seguro</option>
                                                        </select>
                                                    </div>
                                                </div>
                                                <div class="form-group row">
                                                    <div class="col-8">
                                                        <label for="exampleInputEmail1">Objetivo</label>
                                                        <select id="inputState" class="form-control">
                                    <option>Preserva&#231;&#227;o do capital</option>
                                                            <option>Aposentadoria</option>
                                                            <option>Aumento do capital</option>
                                    <option>Diversifica&#231;&#227;o em outros pa&#237;ses</option>
                                                            <option>Legado</option>
                                                        </select>
                                                    </div>
                                                    <div class="col-4">
                                                        <label for="exampleInputEmail1">Rendimento esperado</label>
                                                        <input type="text" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder=""/>
                    </div>
                                                    </div>
                                                    <input type="submit" id="botao" class="px-2" value="Cadastrar" />
              </form>
                                            </div>
    </div>
        );
    }
}

export default CadastroCliente; 
