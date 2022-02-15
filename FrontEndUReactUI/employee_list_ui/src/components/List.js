import React from 'react';
import { useSelector, useDispatch } from "react-redux";
import allActions from "../actions";

export const List = () => {
    // const list = useSelector(store => store.empR);
    // const dispatch = useDispatch();
    return (
        <div>
            <div className="container mt-5">
                <table className="table">
                    <thead>
                        <tr>
                            <td>
                                Please click on Edit to find more details about each employee.
                                {dispatch(allActions.employeeListAction())}
                            </td>
                            <td>
                                <button type="button" className="btn btn-primary">Primary</button>
                            </td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                Name <br />
                                Address <br />
                                OnGoing <br />
                            </td>
                            <td>
                                <a href="#">Edit</a> &nbsp;| &nbsp;
                                <a href="#">Delete</a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    )
}