import React,{ useState }  from 'react';
import logo from './logo.svg';
import './App.css';
import { Header } from './components/Header/Header';
import { Data } from './components/Data/Data';
import { DataMove } from './components/DataMove/DataMove';
import { AddInventory } from './components/AddInventory/AddInventory';
import { UpdInventory } from './components/UpdInventory/UpdInventory';
import { DataStore } from './components/DataStore/DataStore';

import { getDataFromApiAction,getDataFromApiIndexAction,
  delDataFromApiIndexAction,
  updDataFromApiIndexAction,
  addDataFromApiIndexAction, 
  getDataStoreFromApiAction } from './store/DataReducer';
import { useDispatch, useSelector } from 'react-redux';

let updIndex = -1
const App= () => {
 // showData = false
 const [showData, setShowData] = useState(false);
 const [showForm, setShowForm] = useState(false); 
 const [showFormUpd, setShowFormUpd] = useState(false); 

  const dispatch = useDispatch()
  
  let dataArr = useSelector(state => state.DataReducer.dataArr)
  let dataArrMove = useSelector(state => state.DataReducer.dataArrMove)
  let dataArrStore = useSelector(state => state.DataReducer.dataArrStore)
  const fetchMainData = () =>{
    setShowForm(false)
    setShowData(true);
    setShowFormUpd(false)
    dispatch(getDataFromApiAction())
  }
  const fetchMainDataStore = () =>{
    setShowForm(false)
    setShowData(false);
    setShowFormUpd(false)
    dispatch(getDataStoreFromApiAction())
  }

  const itemInfo=(index)=>{
    console.log(index.target);
    setShowData(false)
    setShowForm(false)
    setShowFormUpd(false)
    dispatch(getDataFromApiIndexAction(index.target.id))
  }
  const itemInfoMove =(index)=>{
    //console.log(index.target);
    setShowData(false)
    setShowForm(false)
    setShowFormUpd(false)
    dispatch(getDataFromApiIndexAction(index))
  }
  const itemInfoDel =(index)=>{
    //console.log(index.target);
    dispatch(delDataFromApiIndexAction(index))
  }
const itemInfoUpd =(index)=>{
  setShowData(false)
  setShowForm(false)
  setShowFormUpd(true)
  updIndex = index.target.id
  console.log(index.target)
 // dispatch(updDataFromApiIndexAction(index.target))
}
const itemInfoAdd=()=>{
  setShowData(false)
  setShowForm(true)
  setShowFormUpd(false)
 // dispatch(getDataFromApiIndexAction(index))
}
const itemInfoAddInventory = (event) => {
  event.preventDefault();
  // Получаем значения из формы
  const equipmentID = event.target.elements.equipmentID.value;
  const storeID = event.target.elements.storeID.value;
  const stock = event.target.elements.stock.value;
  let obj ={
    inventory_ID : String(Math.trunc(Math.random() * Date.now().toString().replace(/\D/g, ''))).slice(0, 9),
    equipment_ID : equipmentID,
    store_ID : storeID,
    stock : stock
  }
  setShowData(false)
  setShowForm(false)
  setShowFormUpd(false)
  dispatch(addDataFromApiIndexAction(obj))
  // Делаем что-то с полученными данными, например, передаем их в функцию props.itemInfoUpdInventory
 // props.itemInfoUpdInventory({ equipmentID, storeID, stock });
}
const itemInfoUpdInventory = (event) => {
  event.preventDefault();
  console.log(updIndex)
  console.log(dataArrMove)

  const equipmentID = event.target.elements.equipmentID.value !== "" ? event.target.elements.equipmentID.value : dataArrMove[0].equipment_ID;
  const storeID = event.target.elements.storeID.value !== "" ? event.target.elements.storeID.value : dataArrMove[0].store_ID;
  const stock = event.target.elements.stock.value !== "" ? event.target.elements.stock.value : dataArrMove[0].stock;;
  let obj ={
    inventory_ID : updIndex,
    equipment_ID : equipmentID,   
    store_ID : storeID,
    stock : stock
  }
  console.log(obj)
  setShowData(false)
  setShowForm(false)
  setShowFormUpd(false)
  dispatch(updDataFromApiIndexAction(obj))
}

  return (
    <div>
      <Header fetchMainData={fetchMainData}
      fetchMainDataStore = {fetchMainDataStore} 
      />
      {showData &&(
      <Data dataArr = {dataArr}
      itemInfo = {itemInfo}
      itemInfoAdd = {itemInfoAdd}
      /> )}
      {showForm &&( <AddInventory 
      itemInfoAddInventory = {itemInfoAddInventory}
      />
        )}
      {showFormUpd &&( <UpdInventory 
      itemInfoUpdInventory = {itemInfoUpdInventory}
      />
        )}
      <DataMove dataArrMove = {dataArrMove}
      itemInfoMove = {itemInfoMove}
      itemInfoDel = {itemInfoDel}
      itemInfoUpd = {itemInfoUpd}
      />
      <DataStore
      dataArrStore = {dataArrStore}
      />
    </div>
  );
}

export default App;
