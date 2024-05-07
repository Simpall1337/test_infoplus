import React from "react";
import './Data.css';

export const Data = (props) =>{
    console.log(props)
    return (
        <div className="card-container">
            {props.dataArr.map((item, index) => (
               <button key={index} className="card" id = {`${item.equipment_ID}`}onClick={props.itemInfo}>{item.name}</button>
            ))}
            <button className="card" onClick={props.itemInfoAdd}>add new</button>
        </div>
    );
}