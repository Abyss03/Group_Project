#pragma once
#include "MyForm1.h"
#include "frmQuiz.h"

namespace Project1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  btnPassSec;
	private: System::Windows::Forms::Button^  btnAntiVirus;
	protected:


	private: System::Windows::Forms::Button^  btnSpamEmail;

	private: System::Windows::Forms::Button^  btnRetailBanking;




	private: System::Windows::Forms::Button^  btnQuiz;
	private: System::Windows::Forms::Button^  btnExit;


	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->btnPassSec = (gcnew System::Windows::Forms::Button());
			this->btnAntiVirus = (gcnew System::Windows::Forms::Button());
			this->btnSpamEmail = (gcnew System::Windows::Forms::Button());
			this->btnRetailBanking = (gcnew System::Windows::Forms::Button());
			this->btnQuiz = (gcnew System::Windows::Forms::Button());
			this->btnExit = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// btnPassSec
			// 
			this->btnPassSec->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnPassSec->Location = System::Drawing::Point(887, 510);
			this->btnPassSec->Name = L"btnPassSec";
			this->btnPassSec->Size = System::Drawing::Size(220, 197);
			this->btnPassSec->TabIndex = 0;
			this->btnPassSec->Text = L"Password Security Checker";
			this->btnPassSec->UseVisualStyleBackColor = true;
			this->btnPassSec->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// btnAntiVirus
			// 
			this->btnAntiVirus->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAntiVirus->Location = System::Drawing::Point(30, 59);
			this->btnAntiVirus->Name = L"btnAntiVirus";
			this->btnAntiVirus->Size = System::Drawing::Size(220, 186);
			this->btnAntiVirus->TabIndex = 1;
			this->btnAntiVirus->Text = L"Antivirus and Malware";
			this->btnAntiVirus->UseVisualStyleBackColor = true;
			this->btnAntiVirus->Click += gcnew System::EventHandler(this, &MyForm::btnAntiVirus_Click);
			// 
			// btnSpamEmail
			// 
			this->btnSpamEmail->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnSpamEmail->Location = System::Drawing::Point(30, 265);
			this->btnSpamEmail->Name = L"btnSpamEmail";
			this->btnSpamEmail->Size = System::Drawing::Size(220, 192);
			this->btnSpamEmail->TabIndex = 2;
			this->btnSpamEmail->Text = L"Spam Emails";
			this->btnSpamEmail->UseVisualStyleBackColor = true;
			this->btnSpamEmail->Click += gcnew System::EventHandler(this, &MyForm::button3_Click);
			// 
			// btnRetailBanking
			// 
			this->btnRetailBanking->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Regular,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->btnRetailBanking->Location = System::Drawing::Point(30, 481);
			this->btnRetailBanking->Name = L"btnRetailBanking";
			this->btnRetailBanking->Size = System::Drawing::Size(220, 181);
			this->btnRetailBanking->TabIndex = 3;
			this->btnRetailBanking->Text = L"Online Retail and Banking";
			this->btnRetailBanking->UseVisualStyleBackColor = true;
			// 
			// btnQuiz
			// 
			this->btnQuiz->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnQuiz->Location = System::Drawing::Point(887, 278);
			this->btnQuiz->Name = L"btnQuiz";
			this->btnQuiz->Size = System::Drawing::Size(220, 197);
			this->btnQuiz->TabIndex = 6;
			this->btnQuiz->Text = L"Quiz";
			this->btnQuiz->UseVisualStyleBackColor = true;
			this->btnQuiz->Click += gcnew System::EventHandler(this, &MyForm::button6_Click);
			// 
			// btnExit
			// 
			this->btnExit->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 27.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(136)));
			this->btnExit->Location = System::Drawing::Point(540, 133);
			this->btnExit->Name = L"btnExit";
			this->btnExit->Size = System::Drawing::Size(126, 67);
			this->btnExit->TabIndex = 7;
			this->btnExit->Text = L"EXIT";
			this->btnExit->UseVisualStyleBackColor = true;
			this->btnExit->Click += gcnew System::EventHandler(this, &MyForm::button7_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1135, 741);
			this->Controls->Add(this->btnExit);
			this->Controls->Add(this->btnQuiz);
			this->Controls->Add(this->btnRetailBanking);
			this->Controls->Add(this->btnSpamEmail);
			this->Controls->Add(this->btnAntiVirus);
			this->Controls->Add(this->btnPassSec);
			this->Name = L"MyForm";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Text = L"Keeping Safe Online Tutorials";
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
	}
	private: System::Void button6_Click(System::Object^  sender, System::EventArgs^  e) {
				 frmQuiz ^quiz = gcnew frmQuiz;
				 quiz->Show();
				 
	}
private: System::Void button3_Click(System::Object^  sender, System::EventArgs^  e) {
	MyForm1 ^form1 = gcnew MyForm1;
	form1->Show();
}
private: System::Void button7_Click(System::Object^  sender, System::EventArgs^  e) {
	Application::Exit();
}
private: System::Void btnAntiVirus_Click(System::Object^  sender, System::EventArgs^  e) {
}
};
}
