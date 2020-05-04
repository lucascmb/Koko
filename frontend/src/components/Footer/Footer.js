import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import '../../global.css';
import './Footer.css';
import Shawee from '../../assets/Shawee.png';
import Gorila from '../../assets/Gorila.svg';

class Footer extends Component {
    render() {
        return (
            <div className="footer container">
                <div className="row">
                    <div className="bloco">
                        <h5 className="copyright">© 2020 Copyright Koko - Todos os Direitos Reservados.</h5>
                        <div className="patrocinadores">
                            <h2>Patrocinadores</h2>
                            <Link to="/" className="shawee">
                                <img src={Shawee} alt="Logo" className="brand-logo shawee-logo"/>
                            </Link>
                            <Link to="/" className="gorila">
                                <img src={Gorila} alt="Logo" className="brand-logo gorila-logo"/>
                            </Link>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
  }
  
  export default Footer; 