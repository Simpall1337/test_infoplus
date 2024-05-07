import React from "react";
//import './DataMove.css';

export const DataStore = (props) =>{
    console.log(props)
    return (
        <div className="card-container">
                {props.dataArrStore.map((item, index) => (
                <div key={index} className="card" id={item.inventory_ID}>
                    <div className="buttons-container buttons-centre">
                    <span>Магазин :{item.name}</span>
                    <span>Локація :{item.location}</span>
                    <span>Контакти :{item.contact_Info}</span>
                    </div>
                </div>
            ))}
        </div>
    );
}