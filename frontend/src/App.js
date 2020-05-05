import React, { Component } from 'react';
import {BrowserRouter,Route,Switch} from 'react-router-dom';
import './global.css';
import './App.css';
import NavBar from './components/Navbar/Navbar';
import Footer from './components/Footer/Footer';
import Home from './pages/Home/Home';
import Assessor from './pages/Assessor/Assessor';
import Investidor from './pages/Investidor/Investidor';
import AdvisorList from './pages/ListaAdvisor/AdvisorList';
import Advisor from './pages/Advisor/Advisor';
import CadastroCliente from './pages/CadastroCliente/cadastrocliente';

  class App extends Component {
    render() {
        return (
          <BrowserRouter>
          <div className="App">
            <NavBar/>
            <Switch>
              <Route exact path="/" component={Home}/>
              <Route path="/assessor" component={Assessor}/>
              <Route path="/investidor" component={Investidor} />
            <Route path="/advisorList" component={AdvisorList} />
                        <Route path="/advisor" component={Advisor} />
                        <Route path="/cadastro" component={CadastroCliente} />
            </Switch>
            <Footer/>
          </div>
          </BrowserRouter>
        );
      }
  }

  export default App;