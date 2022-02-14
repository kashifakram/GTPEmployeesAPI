import employeeReducer from "./employeeList";
import { combineReducers } from "redux";

const allReducers = combineReducers({
    empR: employeeReducer
})

export default allReducers;