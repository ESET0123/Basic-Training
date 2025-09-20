import propTypes from 'prop-types'

export default function PrototTypeComponent({name, usn}) {

  return (
    <div>
      
    </div>
  )
}

PrototTypeComponent.propTypes = {
    name: propTypes.string.isRequired,
    usn: propTypes.number.isRequired,
};
