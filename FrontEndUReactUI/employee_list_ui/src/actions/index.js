import * as actionTypes from "./types";
import {v4 as uuidv4} from "uuid";

const employeeListAction = () => {return {type: actionTypes.FETCHLIST};};
const employeeSingleAction = nr => {return {type: actionTypes.FETCHSINGLE, payload: nr};};
const employeeModifyAction = {type: actionTypes.MODIFY};
const employeeCreateAction = {type: actionTypes.CREATE};
const employeeDeleteAction = {type: actionTypes.DELETE};

const deleteBookmark = id => ({
    type: actionTypes.DELETEBOOKMARK,
    payload: {

    }
});

const addBookmark = ({title, url}) => ({
    type: actionTypes.ADDBOOKMARK,
    payload: {
        id: uuidv4(),
        title,
        url
    }
})

export default {
    employeeListAction, employeeSingleAction, employeeModifyAction, employeeCreateAction, employeeDeleteAction, deleteBookmark
}