import React from 'react'
import DocumentIcon from '../../../public/assets/icons/document.png'
import UserIcon from '../../../public/assets/icons/user-circle.png'
import BriefcaseIcon from '../../../public/assets/icons/briefcase.png'

import './Task.styled.scss'

const Task = ({ title, description, user }) => {
	return (
		<div className='task__block'>
			<div className='task__title'>
				<img src={DocumentIcon} />
				<h3>{title}</h3>
			</div>
			<div className='task__user'>
				<img src={UserIcon} />
				<p>Nate Martins</p>
			</div>
			<div className='task__project'>
				<img src={BriefcaseIcon} />
				<p>React</p>
			</div>
		</div>
	)
}

export default Task
