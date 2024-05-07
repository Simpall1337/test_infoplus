import React from "react";
//import "./Data.css";

export const UpdInventory = (props) => {
  console.log(props);
  return (
    <div className="add-form">
      {/* Здесь разместите вашу форму */}
      <form onSubmit={props.itemInfoUpdInventory}>
        <label htmlFor="equipmentID">Equipment ID:</label>
        <input type="number" id="equipmentID" name="equipmentID"/>

        <label htmlFor="storeID">Store ID:</label>
        <input type="number" id="storeID" name="storeID" />

        <label htmlFor="stock">Stock:</label>
        <input type="number" id="stock" name="stock" />

        <button type="submit">Отправить</button>
      </form>
    </div>
  );
};
