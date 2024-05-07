import React from "react";
import './Header.css';

export const Header = (props) =>{
    return (
        <header className="container">
                <div className="item" onClick={props.fetchMainData}>
                    <button>
                      Товари
                    </button>
                </div>
                <div className="item" onClick={props.fetchMainDataStore}>
                    <button>
                    Магазини
                    </button>
                </div>
        </header>
    );
}