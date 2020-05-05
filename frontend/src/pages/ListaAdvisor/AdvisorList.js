import React, { Component } from 'react';
import '../../global.css';
import './AdvisorList.css';
import '../../assets/css/icons/css/all.css'
import '../../assets/css/style.css'
import Advisors from '../../components/advisors';

class AdvisorList extends Component {

    state = {
        advisors: []
    }

    componentDidMount() {
        fetch('https://localhost:44309/advisors')
            .then(res => res.json())
            .then((data) => {
                this.setState({ advisors: data })
            }).catch(console.log)
    }

    render() {
        return (
            <div class="container" style={{ paddingTop: 80 }}>
                <div class = "">
                <div id="advisors-box" class="card mb-5">
                    <div class="card-header d-flex">
                        <h5 class="text-white mr-auto">Lista de Advisors</h5>
                        <div class="d-flex">
                            <div class="busca">
                                <input type="text" ></input>
                                    <i class="fas fa-search text-white"></i>
                            </div>
                            <div class="filtro pl-4 text-white">
                                <span>Filtro</span>
                                <i class="fas fa-filter"></i>
                            </div>
                        </div>
                    </div>
                        <div class="card-body">
                            <ul class="list-unstyled">
                                <Advisors advisors={this.state.advisors} />
                                   
                </ul>
            </div>
                    </div>
                    </div>
    </div>
        );
    }
}

export default AdvisorList; 