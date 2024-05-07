import React from "react";
import './DataMove.css';

export const DataMove = (props) =>{
    console.log(props)
    return (
        <div className="card-container">
                {props.dataArrMove.map((item, index) => (
                <div key={index} className="card" id={item.inventory_ID}>
                    <div className="buttons-container buttons-centre">
                    <span>Назва: {item.nameEquipment}</span>
                    <span>Магазин: {item.nameStore}</span>
                    <span>Кількість: {item.stock}</span>
                    </div>
                    <div className="buttons-container">
                    <button  id = {`${item.inventory_ID}`}onClick={props.itemInfoDel}>del</button>
                    <button id = {`${item.inventory_ID}`} onClick={props.itemInfoUpd}>upd</button>
                    </div>
                </div>
            ))}
        </div>
    );
}