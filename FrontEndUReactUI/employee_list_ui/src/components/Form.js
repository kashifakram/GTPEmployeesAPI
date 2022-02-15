import React from 'react';
import Date from './Date';
import Radio from './Radio';

export default function Form(props) {
    return (
        <form className="row g-3">
            <h2>Personal information</h2>
            <div className="col">
                <label for="firstname" className="form-label">First name</label>
                <input type="text" className="form-control" placeholder="John" aria-label="First name" id="firstname" />
            </div>
            <div className="col">
                <label for="middlename" className="form-label">Middle name (if applicable)</label>
                <input type="text" className="form-control" placeholder="" aria-label="Last name" id="middlename" />
            </div>
            <div className="col">
                <label for="lastname" className="form-label">Middle name (if applicable)</label>
                <input type="text" className="form-control" placeholder="Smith" aria-label="Last name" id="lastname" />
            </div>

            <h2>Contact details</h2>

            <div className="col-md-12">
                <label for="inputEmail4" className="form-label">Email address</label>
                <input type="email" className="form-control" id="inputEmail4" placeholder="smith.riley@gmail.com" />
            </div>



            <div className="col-12">
                <label className="visually-hidden" for="mobile">Mobile number</label>
                <small>Must be an Australian number</small>
                <div className="input-group">
                    <div className="input-group-text">+61</div>
                    <input type="text" className="form-control" id="mobile" placeholder="0412345678" />
                </div>
            </div>



            <div className="col-12">
                <label for="inputAddress" className="form-label">Residential address</label>
                <small>Start typing address</small>
                <input type="text" className="form-control" id="inputAddress" placeholder="1234 Example St, Sydney NSW 2000" />
            </div>

            <h2>Employee status</h2>

            <p>What is contract type?</p>


            <Radio type="contract" />


            <Date type="start" />

            <Date type="end" />



            <div className="col-12">
                <div className="form-check">
                    <input className="form-check-input" type="checkbox" id="onGoing" />
                    <label className="form-check-label" for="onGoing">
                        On going
                    </label>
                </div>
            </div>

            <Radio type="time" />

            <div className="col-4">
                <label className="visually-hidden" for="mobile">Hours per week</label>
                <input type="text" className="form-control" id="mobile" placeholder="" />
            </div>

            <div className="col-4">
                <button type="submit" className="btn btn-primary">Save</button>
            </div>
            <div className="col-4">
                <button type="button" className="btn btn-secondary">Cancel</button>
            </div>
        </form>
    )
}
