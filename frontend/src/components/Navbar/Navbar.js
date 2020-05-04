import React, { Component } from 'react';
import {NavLink, Link} from 'react-router-dom';
import {Navbar, Nav} from 'react-bootstrap';
import '../../global.css';
import './Navbar.css';
import logonav from '../../assets/Koko.png';

class NavBar extends Component {
    render() {
        return (
            <>
            <Navbar>
                <Link to="/" className="logo">
                    <img src={logonav} alt="Logo" className="brand-logo"/>
                </Link>
                <Nav className="mr-auto">
                <ul id="nav-mobile" className="right hide-on-med-and-down">
                    <li><NavLink className="link" to="/assessor/">Assessor</NavLink></li>
                    <li><NavLink className="link" to="/investidor/">Investidor</NavLink></li>
                </ul>
                </Nav>
            </Navbar>
            </>

            
        );
    }
  }
  
  export default NavBar; 