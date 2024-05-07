import axios from "axios";
let datas = [
  {
    name: "name1",
    id: "1"
  },
  { 
    name: "name2",
    id: "2"
  },
];
let datas2 = [
    {
      name: "name1()",
      id: "1()"
    }
  ];
  let datas3 = [
  ];
  let datas4 = [
    {
    name: "name2()",
    id: "2()"
    }
  ];
let defaultState = {
  dataArr: [],
  dataArrMove: [],
  dataArrStore: []
};

const GET_DATA_FROM_API = "GET_DATA_FROM_API";
const GET_DATA_FROM_API_INDEX = "GET_DATA_FROM_API_INDEX";
const DEL_DATA_FROM_API_INDEX = "DEL_DATA_FROM_API_INDEX";
const UPD_DATA_FROM_API_INDEX = "UPD_DATA_FROM_API_INDEX";
const GET_DATA_STORE_FROM_API = "GET_DATA_STORE_FROM_API";

export const DataReducer = (state = defaultState, action) => {
  switch (action.type) {
    case GET_DATA_FROM_API: {
      return {...state, dataArr: action.payload,
        dataArrMove: [],
        dataArrStore:[]
       };
    }
    case GET_DATA_FROM_API_INDEX: {
        return {...state, dataArrMove: action.payload,
            dataArr : []
        };
    }
    case GET_DATA_STORE_FROM_API: {
      return {...state, dataArrStore: action.payload,
        dataArr: [],
        dataArrMove: []
       };
    }
    case DEL_DATA_FROM_API_INDEX: {
      return {...state, dataArrMove: []
      };
    }
    case UPD_DATA_FROM_API_INDEX:{
      return {...state, dataArrMove: action.payload};
    }
    default:
      return state;
  }
};

export const getDataFromApi = (payload) => ({
  type: GET_DATA_FROM_API,
  payload,
});
export const getDataStoreFromApi = (payload) => ({
  type: GET_DATA_STORE_FROM_API,
  payload,
});
export const getDataFromApiIndex = (payload) => ({
    type: GET_DATA_FROM_API_INDEX,
    payload,
});
export const delDataFromApiIndex = (payload) => ({
  type: DEL_DATA_FROM_API_INDEX,
  payload,
});
export const updDataFromApiIndex = (payload) => ({
  type: UPD_DATA_FROM_API_INDEX,
  payload,
});

export const getDataFromApiAction = () => {
  return async function (dispatch) {
   // console.log("1");
  let fetchResultEquipment = await axios.get('https://localhost:7023/api/Equipment')
   
    dispatch(getDataFromApi(fetchResultEquipment.data));
  };
};

export const getDataStoreFromApiAction = () => {
  return async function (dispatch) {
   // console.log("1");
  let fetchResultStore = await axios.get('https://localhost:7023/api/Store')
   console.log(fetchResultStore)
    dispatch(getDataStoreFromApi(fetchResultStore.data));
  };
};

export const getDataFromApiIndexAction=(index)=>{
    return async function (dispatch) {
      console.log(index)
      let fetchResultEquipment = await axios.get('https://localhost:7023/api/Equipment', {
        params: {
          id: index
        }
      });
      let newObj = []
      let fetchResultInventory = await axios.get('https://localhost:7023/api/Inventory')
      let fetchResultStores = await axios.get('https://localhost:7023/api/Store')
      console.log(fetchResultEquipment)
      fetchResultInventory.data.forEach(obj1 => {
        console.log("s")

        let obj2 = fetchResultEquipment.data.find(obj2 => obj2.equipment_ID === obj1.equipment_ID);
        //let obj3 = fetchResultStores.data.find(obj3 => obj3.store_ID === obj1.store_ID);
        
        if (obj2) {
          const combinedObj = { ...obj1, nameEquipment : obj2.name };
          newObj.push(combinedObj)
          console.log(newObj)
        } 
      }); 
      newObj.forEach(obj1 =>{
        let obj3 = fetchResultStores.data.find(obj3 => obj3.store_ID === obj1.store_ID);
        if (obj3) {
          console.log(obj3)
          obj1.nameStore = obj3.name 
          console.log(obj1)
        } 
      });
      console.log(newObj)
     dispatch(getDataFromApiIndex(newObj))
    };
}

export const delDataFromApiIndexAction =(index)=>{
  return async function(dispatch){
    console.log(index.target.id)
    let fetchResult = await axios.delete('https://localhost:7023/api/Inventory', {
      params: {
        id: index.target.id 
      }
    });
    dispatch(delDataFromApiIndex(fetchResult))
  };
}

export const updDataFromApiIndexAction =(index)=>{
  return async function(dispatch){
    console.log(index)
    let fetchResult = await axios.patch('https://localhost:7023/api/Inventory', index);
    console.log(fetchResult)
  //  dispatch(updDataFromApiIndex(datas4))
  };
}
export const addDataFromApiIndexAction =(index)=>{
  return async function(dispatch){
    console.log(index)
    let fetchResult = await axios.post('https://localhost:7023/api/Inventory', index);
    console.log(fetchResult)
    //dispatch(addDataFromApiIndex())
  };
}





