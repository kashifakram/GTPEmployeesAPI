import React from 'react'

export default function Form(props) {
    return (
        <div className="row">
            <div className="col-md-4">
                <form>
                    <div className="text-danger"></div>
                    <input type="hidden" />
                    <div className="form-group">
                        <label className="control-label"></label>
                        <input className="form-control" />
                    </div>
                    <div class="form-group">
                        <label className="control-label"></label>
                        <input className="form-control" />
                    </div>
                    <div class="form-group">
                        <input type="submit" value="Save" class="btn btn-primary" />
                    </div>
                </form>
            </div>
        </div>
    )
}
